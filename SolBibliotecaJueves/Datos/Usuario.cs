using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class Usuario
    {
        public static bool Validar(Entidades.Usuario usuario)
        {
            bool blnExisteUsuario = false;
            string strSQL = "select * from Usuarios where IdUsuario = @IdUsuario and Contraseña = @Contraseña";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comValidar = new SqlCommand(strSQL, objConexion);
            comValidar.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
            comValidar.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
            SqlDataReader drUsuario;
            
            objConexion.Open();
            drUsuario = comValidar.ExecuteReader();
            blnExisteUsuario = drUsuario.Read();
            objConexion.Close();
            return blnExisteUsuario;
        }
    }
}
