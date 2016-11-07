using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
  public class Editorial
    {
        Datos.Editorial objDatosEditorial = new Datos.Editorial();
        public void Agregar(string pDescripcion)
        {
            objDatosEditorial.Agregar(pDescripcion);
        }
        public void Modificar(int pId, string pDescripcion)
        {
            objDatosEditorial.Modificar(pId, pDescripcion);
        }
        public DataTable TraerTodos()
        {
            return objDatosEditorial.TraerTodos();
        }
        public void Borrar(int pId)
        {
            objDatosEditorial.Borrar(pId);
        }
    }
}
