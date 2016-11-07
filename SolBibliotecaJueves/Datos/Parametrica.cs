using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Parametrica
    {
        private string tabla;

        public Parametrica(string pTabla)
        {
            tabla = pTabla;
        }
        
        // metodos
        public void Agregar(string pDescripcion)
        {
            string strSP = "proc_alta";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comAlta = new SqlCommand(strSP, objConexion);
            comAlta.CommandType = CommandType.StoredProcedure;
            comAlta.Parameters.AddWithValue("@Tabla", tabla);
            comAlta.Parameters.AddWithValue("@Descripcion", pDescripcion);
            objConexion.Open();
            comAlta.ExecuteNonQuery();
            objConexion.Close();

        }
        public void Modificar(int pId,string pDescripcion)
        {
            string strSP = "proc_modifica";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comModifica = new SqlCommand(strSP, objConexion);
            comModifica.CommandType = CommandType.StoredProcedure;
            comModifica.Parameters.AddWithValue("@ID", pId);
            comModifica.Parameters.AddWithValue("@Tabla", tabla);
            comModifica.Parameters.AddWithValue("@Descripcion", pDescripcion);
            objConexion.Open();
            comModifica.ExecuteNonQuery();
            objConexion.Close();
        }
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSP = "proc_traer";
            SqlDataAdapter daTraer = new SqlDataAdapter(strSP, Conexion.strConexion);
            daTraer.SelectCommand.CommandType = CommandType.StoredProcedure;
            daTraer.SelectCommand.Parameters.AddWithValue("@Tabla", tabla);
            daTraer.Fill(dt);
            return dt;
        }
        public void Borrar(int pId)
        {
            string strSP = "proc_baja";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comBorrar = new SqlCommand(strSP, objConexion);
            comBorrar.CommandType = CommandType.StoredProcedure;
            comBorrar.Parameters.AddWithValue("@ID", pId);
            comBorrar.Parameters.AddWithValue("@Tabla", tabla);
            objConexion.Open();
            comBorrar.ExecuteNonQuery();
            objConexion.Close();
        }
    }
}
