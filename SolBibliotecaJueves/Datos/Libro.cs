using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public static class Libro
    {
        // alta de libro
        public static void Agregar(Entidades.Libro pLibro, DataTable pAutores)
        {
            string strProc = "proc_alta_libro";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comAgregar = new SqlCommand(strProc, objConexion);
            comAgregar.CommandType = CommandType.StoredProcedure;
            // parametros
            comAgregar.Parameters.AddWithValue("@isbn", pLibro.ISBN);
            comAgregar.Parameters.AddWithValue("@titulo", pLibro.Titulo);
            comAgregar.Parameters.AddWithValue("@edicion", pLibro.Edicion);
            comAgregar.Parameters.AddWithValue("@idGenero", pLibro.Genero.ID);
            comAgregar.Parameters.AddWithValue("@idEditorial", pLibro.Editorial.ID);

            // autores
            SqlParameter paramAutores = new SqlParameter();
            paramAutores.ParameterName = "@Autores";
            paramAutores.Direction = ParameterDirection.Input;
            paramAutores.SqlDbType = SqlDbType.Structured;
            paramAutores.Value = pAutores;

            comAgregar.Parameters.Add(paramAutores);
            try
            {
                objConexion.Open();
                comAgregar.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                if (objConexion.State == ConnectionState.Open)
                {
                    objConexion.Close();
                }
            }


        }
        public static DataTable TraerTodos()
        {
            DataTable dtLibros = new DataTable();
            string strSQL = "Select * from vista_libros ";
            SqlDataAdapter daTraer = new SqlDataAdapter(strSQL, Conexion.strConexion);
            daTraer.Fill(dtLibros);
            return dtLibros;
        }

        public static List<Entidades.Autor> TraerAutoresxISBN(string pISBN)
        {
            List<Entidades.Autor> lista = new List<Entidades.Autor>();
            string strSQL = "select a.Apellido,a.Nombre from LibrosAutores la join autores a on a.IdAutor=la.IdAutor where la.isbn=" + pISBN;

            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlDataReader drLibro;
            SqlCommand comLibro = new SqlCommand(strSQL, objConexion);
            objConexion.Open();
            drLibro = comLibro.ExecuteReader();
            while (drLibro.Read())
            {
                Entidades.Autor a = new Entidades.Autor();
                a.Apellido = drLibro[0].ToString();
                a.Nombre = drLibro[1].ToString();
                lista.Add(a);

            }
            objConexion.Close();
            return lista;
        }

        public static DataTable TraerParaModificar()
        {
            DataTable dtLibros = new DataTable();
            string strSQL = "Select * from vista_modifica_libros ";
            SqlDataAdapter daTraer = new SqlDataAdapter(strSQL, Conexion.strConexion);
            daTraer.Fill(dtLibros);
            return dtLibros;
        }

        public static Entidades.Libro TraerUno(string ISBN)
        {
            Entidades.Libro objEntidadLibro = new Entidades.Libro();
            string strSQL = "Select* from Libros where isbn = " + ISBN;
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlDataReader drLibro;
            SqlCommand comLibro = new SqlCommand(strSQL, objConexion);
            objConexion.Open();
            drLibro = comLibro.ExecuteReader();
            drLibro.Read();
            objEntidadLibro.ISBN = drLibro["ISBN"].ToString();
            objEntidadLibro.Titulo = drLibro["Titulo"].ToString();

            Entidades.Genero g = new Entidades.Genero();
            g.ID = Convert.ToInt32(drLibro["IdGenero"]);
            objEntidadLibro.Genero = g;

            Entidades.Editorial e = new Entidades.Editorial();
            e.ID = Convert.ToInt32(drLibro["IdEditorial"]);
            objEntidadLibro.Editorial = e;

            objEntidadLibro.Edicion = Convert.ToInt32(drLibro["Edicion"]);

            objConexion.Close();

            return objEntidadLibro;
         }
    }
}
