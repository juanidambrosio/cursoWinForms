﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class Libro
  {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int Edicion { get; set; }
        public Genero Genero { get; set; }
        public Editorial Editorial { get; set; }
        public List<Autor> Autores { get; set; }
  }
}
