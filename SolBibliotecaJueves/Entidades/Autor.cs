using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Paises
    {
        Argentina,
        Uruguay,
        Peru,
        Chile,
        Colombia

    }
    public class Autor
    {
        // constructor
        public Autor()
        {
            this.Nacionalidad = Paises.Argentina;

        }
        public Autor(
            int pCodigo,string pApellido,
            string pNombre,
            DateTime pFecha,
            Paises pPais
            )
        {
            this.Codigo = pCodigo;
            this.Apellido = pApellido;
            this.Nombre = pNombre;
            this.FechaNacimiento = pFecha;
            this.Nacionalidad = pPais;
        }


        public int Codigo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Paises Nacionalidad { get; set; }
        public List<Libro> Libros { get; set; }

        // propiedad estatica
        public static string Saludo { get; set; }
    }
}
