using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class Libro
    {
        // metodos
        public void Agregar(List<Entidades.Libro> pLibros,Entidades.Libro pLibro)
        {
            pLibros.Add(pLibro);
        }

        public DataTable TraerTodos()
        {
            return Datos.Libro.TraerTodos();
        }
        public void Agregar(Entidades.Libro pLibro,DataTable pAutores)
        {
            try
            {
                Datos.Libro.Agregar(pLibro, pAutores);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }
        public void Borrar(List<Entidades.Libro> pLibros, Entidades.Libro pLibro)
        {
            //TODO implementar codigo para enviar a Capa
            // de Datos
            pLibros.Remove(pLibro);

        }
        public void Modificar() { }

        public List<Entidades.Libro> Listar()
        {
            List<Entidades.Libro> lista = new List<Entidades.Libro>();
            return lista;

        }

        public List<Entidades.Autor> TraerAutoresPorISBN(string ISBN)
        {
            return Datos.Libro.TraerAutoresxISBN(ISBN);
        }

        public DataTable TraerParaModificar()
        {
            return Datos.Libro.TraerParaModificar();
        }

        public Entidades.Libro TraerUno(string ISBN)
        {
            return Datos.Libro.TraerUno(ISBN);
        }
    }
}
