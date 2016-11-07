using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Autor
    {
        // metodos
        public void Agregar(Entidades.Autor pAutor)
        {
            try
            {
                if (pAutor.FechaNacimiento.Year==1930)
                {
                    throw new Exception("NO SE ADMITEN AUTORES NACIDOS ESE AÑO");
                }
                Datos.Autor.Agregar(pAutor);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }
        public void Modificar(Entidades.Autor pAutor)
        {

            Datos.Autor.Modificar(pAutor);
        }

        public void Borrar(int pIdAutor)
        {

            Datos.Autor.Borrar(pIdAutor);

        }
        public DataTable TraerTodos()
        {
            return Datos.Autor.TraerTodos();
        }
        public List<string> TraerPaises()
        {
            List<string> lista = new List<string>();
            foreach (Entidades.Paises p in Enum.GetValues(typeof(Entidades.Paises)))
            {
                lista.Add(p.ToString());

            }
            return lista;
        }

        public Entidades.Autor TraerUno(int pIdAutor)
        {
            return Datos.Autor.TraerUno(pIdAutor);
        }
     }
}
