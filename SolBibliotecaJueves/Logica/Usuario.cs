using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Usuario
    {
        public bool Validar(Entidades.Usuario usuario)
        {
            return Datos.Usuario.Validar(usuario);
        }
    }
}
