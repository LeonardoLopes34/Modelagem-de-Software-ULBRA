using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiAula14.Models;

namespace apiAula14.Services
{
    public interface ILivroService
    {
        IEnumerable<Livro> GetAll();
        Livro? GetById(int id);
        Livro Add(Livro livro);
        Livro? Delete(Livro livro);
    }

}