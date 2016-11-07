using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class Autor
    {

        // metodos de acceso a datos
        public static void Agregar(Entidades.Autor pAutor)
        {
            // crear objeto de la clase sqlconnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            // sentencia sql a ejecutar
            string strSQL=@"Insert into 
                   Autores(Apellido,Nombre,FechaNacimiento,Nacionalidad)
                   Values(@Apellido,@Nombre,@FechaNacimiento,@Nacionalidad)";
            // crear objeto de sqlcommand
            SqlCommand comAgregar = new SqlCommand(strSQL, objConexion);

            try
            { 
            // parametros
            comAgregar.Parameters.AddWithValue("@Apellido", pAutor.Apellido);
            comAgregar.Parameters.AddWithValue("@Nombre", pAutor.Nombre);
            comAgregar.Parameters.AddWithValue("@FechaNacimiento", pAutor.FechaNacimiento);
            comAgregar.Parameters.AddWithValue("@Nacionalidad", pAutor.Nacionalidad.ToString());

                
                // abrir conexion a base de datos
                objConexion.Open();

                // ejecuto el comando
                comAgregar.ExecuteNonQuery();
               
            }
            catch (SqlException )
            {
                throw new Exception("Error en la BASE de datos!!!");
            }
            catch (Exception)
            {
                throw new Exception("Error en la capa de datos!!!");
              
            }
            finally
            {
                // cierro la conexion
             if(objConexion.State==ConnectionState.Open)   objConexion.Close();
            }


        }
        public static void Modificar(Entidades.Autor pAutor)
        {
            // crear objeto de la clase sqlconnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            // nombre del stored
            string strProc = "proc_modifica_autor";
            // crear objeto de sqlcommand
            SqlCommand comModificar = new SqlCommand(strProc, objConexion);
            comModificar.CommandType = CommandType.StoredProcedure;
            try
            {
                // parametros
                comModificar.Parameters.AddWithValue("@IdAutor", pAutor.Codigo);
                comModificar.Parameters.AddWithValue("@Apellido", pAutor.Apellido);
                comModificar.Parameters.AddWithValue("@Nombre", pAutor.Nombre);
                comModificar.Parameters.AddWithValue("@FechaNacimiento", pAutor.FechaNacimiento);
                comModificar.Parameters.AddWithValue("@Nacionalidad", pAutor.Nacionalidad.ToString());


                // abrir conexion a base de datos
                objConexion.Open();

                // ejecuto el comando
                comModificar.ExecuteNonQuery();

            }
            catch (SqlException)
            {
                throw new Exception("Error en la BASE de datos!!!");
            }
            catch (Exception)
            {
                throw new Exception("Error en la capa de datos!!!");

            }
            finally
            {
                // cierro la conexion
                if (objConexion.State == ConnectionState.Open) objConexion.Close();
            }


        }
        public static void Borrar(int pIDAutor)
        {
            // crear objeto de la clase sqlconnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            // nombre del stored
            string strSQL = "delete autores where idAutor="+pIDAutor;
            // crear objeto de sqlcommand
            SqlCommand comBorrar = new SqlCommand(strSQL, objConexion);
            
            try
            {
                // abrir conexion a base de datos
                objConexion.Open();

                // ejecuto el comando
                comBorrar.ExecuteNonQuery();

            }
            catch (SqlException)
            {
                throw new Exception("Error en la BASE de datos!!!");
            }
            catch (Exception)
            {
                throw new Exception("Error en la capa de datos!!!");

            }
            finally
            {
                // cierro la conexion
                if (objConexion.State == ConnectionState.Open) objConexion.Close();
            }


        }

        public static DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSQL = "Select IdAutor as Codigo,Apellido + ', ' +Nombre as Autor,FechaNacimiento,Nacionalidad from Autores";
            SqlDataAdapter daTraerTodos = new SqlDataAdapter(strSQL, Conexion.strConexion);
            daTraerTodos.Fill(dt);
            return dt; 
        }

        public static Entidades.Autor TraerUno(int pIdAutor)
        {
            Entidades.Autor objEntidadAutor = new Entidades.Autor();
            string strSQL = "Select * from autores where idAutor=" + pIdAutor;
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comTraerUno = new SqlCommand(strSQL, objConexion);
            SqlDataReader drAutor;
            objConexion.Open(); // abro conexion
            drAutor=comTraerUno.ExecuteReader(); // cargo datareader con la ejecucion del command
            if(drAutor.Read())
            {
                objEntidadAutor.Codigo =Convert.ToInt32(drAutor["idAutor"]);
                objEntidadAutor.Apellido = drAutor["Apellido"].ToString();
                objEntidadAutor.Nombre = drAutor["Nombre"].ToString();
                objEntidadAutor.FechaNacimiento = Convert.ToDateTime(drAutor["FechaNacimiento"]);

                Entidades.Paises objNacionalidad = new Entidades.Paises();
                Enum.TryParse(drAutor["Nacionalidad"].ToString(), out objNacionalidad);
                objEntidadAutor.Nacionalidad = objNacionalidad;


            } 

            return objEntidadAutor;
        }
    }
}
