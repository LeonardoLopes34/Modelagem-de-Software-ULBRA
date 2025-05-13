using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiAula14.Models;

namespace apiAula14.Services
{
    public class LivroService : ILivroService
    {
        private readonly List<Livro> _livros = new();

        public IEnumerable<Livro> GetAll() => _livros;

        public Livro? GetById(int id) =>
            _livros.FirstOrDefault(l => l.Id == id);

        public Livro Add(Livro livro)
        {
            livro.Id = _livros.Count + 1;
            _livros.Add(livro);
            return livro;
        }

        public Livro? Delete(Livro livro)
        {
            var livroExistente = _livros.FirstOrDefault(l => l.Id == livro.Id);
            if (livroExistente != null)
            {
                _livros.Remove(livroExistente);
                return livroExistente;
            }

            return null;
        }
    }
}