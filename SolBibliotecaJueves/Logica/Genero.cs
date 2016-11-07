using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class Genero
    {
        Datos.Genero objDatosGenero = new Datos.Genero();
        public void Agregar(string pDescripcion)
        {
            objDatosGenero.Agregar(pDescripcion);
        }
        public void Modificar(int pId,string pDescripcion)
        {
            objDatosGenero.Modificar(pId, pDescripcion);
        }
        public DataTable TraerTodos()
        {
            return objDatosGenero.TraerTodos();
        }
        public void Borrar(int pId)
        {
            objDatosGenero.Borrar(pId);
        }
    }
}
