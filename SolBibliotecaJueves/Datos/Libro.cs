using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;

namespace Datos
{
    public static class Libro
    {
        // alta de libro
        public static void Agregar(Entidades.Libro pLibro,DataTable pAutores)
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
        public static DataTable TraerParaModificacion()
        {
            DataTable dtLibros = new DataTable();
            string strSQL = "Select * from v_libros ";
            SqlDataAdapter daTraer = new SqlDataAdapter(strSQL, Conexion.strConexion);
            daTraer.Fill(dtLibros);
            return dtLibros;
        }
        public static List<Entidades.Autor> TraerAutoresxISBN(string pISBN)
        {
            List<Entidades.Autor> lista = new List<Entidades.Autor>();
            string strSQL = @"select 
                            a.Apellido,a.Nombre from LibrosAutores 
                            la join autores a on a.idAutor=la.idAutor 
                            where la.isbn=" + pISBN;

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

        public static Entidades.Libro TraerUno(string pISBN)
        {
            Entidades.Libro objEntidadLibro = new Entidades.Libro();
            string strSQL = "Select * from Libros where isbn=" + pISBN;
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlDataReader drLibro;
            SqlCommand comLibro = new SqlCommand(strSQL, objConexion);
            objConexion.Open();
            drLibro = comLibro.ExecuteReader();
            drLibro.Read();
            objEntidadLibro.ISBN = drLibro["Isbn"].ToString();
            objEntidadLibro.Titulo = drLibro["Titulo"].ToString();

            Entidades.Genero g = new Entidades.Genero();
            g.ID = Convert.ToInt32(drLibro["IdGenero"]);
            objEntidadLibro.Genero = g;

            Entidades.Editorial e = new Entidades.Editorial();
            e.ID = Convert.ToInt32(drLibro["idEditorial"]);
            objEntidadLibro.Editorial = e;

            objEntidadLibro.Edicion = Convert.ToInt32(drLibro["Edicion"]);

            objConexion.Close();

            return objEntidadLibro;


        }

        public static void Modificar(Entidades.Libro pLibro)
        {
            // creo objeto de conexion
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            string strProc = "proc_modi_libro";
            SqlCommand comModificar = new SqlCommand(strProc, objConexion);
            // le aclaro que el primer argumento del constructor es un SP
            comModificar.CommandType = CommandType.StoredProcedure;
            comModificar.Parameters.AddWithValue("@ISBN", pLibro.ISBN);
            comModificar.Parameters.AddWithValue("@Titulo", pLibro.Titulo);
            comModificar.Parameters.AddWithValue("@Edicion", pLibro.Edicion);
            comModificar.Parameters.AddWithValue("@IdGenero", pLibro.Genero.ID);
            comModificar.Parameters.AddWithValue("@IdEditorial", pLibro.Editorial.ID);
            try
            {
                // abro la conexion
                objConexion.Open();
                // ejecuto el comando
                comModificar.ExecuteNonQuery();

            }
         
            catch (Exception)
            {
                throw new Exception("Error en la capa de datos");

            }

            finally
            {
                // SE EJECUTA SIEMPRE
                // cierro la conexion
                if (objConexion.State == ConnectionState.Open)
                    objConexion.Close();
            }
        }

        public static List<Entidades.Libro> TraerNovedades()
        {
            List<Entidades.Libro> Novedades = new List<Entidades.Libro>();
            string linea;
            StreamReader archivo = new StreamReader(@"C:\Documentos\Novedades.txt");

            while ((linea = archivo.ReadLine()) != null)
            {
                Entidades.Libro libro = new Entidades.Libro();
                libro.Titulo = linea;
                Novedades.Add(libro);
            }

            archivo.Close();
            return Novedades;
        }

        public static void Comprar(List<string> libros)
        {
            StreamWriter file = new StreamWriter(@"C:\Documentos\Compras.txt");
            foreach (string item in libros)
            {
                file.WriteLine(item);
            }
            file.Close();
        }

        public static void EnviarCorreo(MailMessage pMensaje)
        {
            SmtpClient server = new SmtpClient("smtp.live.com", 587);
            server.Credentials = new System.Net.NetworkCredential("p.romanazzi@live.com.ar", "password");
            server.EnableSsl = true;
            server.Send(pMensaje);

        }

    }
}
