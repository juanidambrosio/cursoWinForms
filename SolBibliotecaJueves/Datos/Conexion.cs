using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos
{
   internal static class Conexion
    {
        internal static string strConexion =ConfigurationManager.ConnectionStrings["strConexion"].ToString() ;

    }
}
