using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiAula14.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public int AutorId { get; set; }
        public Autor? Autor { get; set; }
    }
}