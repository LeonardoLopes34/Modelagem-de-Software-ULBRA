using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiAula14.Models;
using apiAula14.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiAula14.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroService _livroService;

        // Injeção de Dependência via Construtor
        public LivrosController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Livro>> Get() =>
            Ok(_livroService.GetAll());

        [HttpGet("{id}")]
        public ActionResult<Livro> GetById(int id)
        {
            var livro = _livroService.GetById(id);
            return livro is null ? NotFound() : Ok(livro);
        }

        [HttpPost]
        public ActionResult<Livro> Delete(Livro livro)
        {
            var livroRemovido = _livroService.Delete(livro);

            if (livroRemovido == null)
            {
                return NotFound(); // Retorna 404 se o livro não existir
            }

            return Ok(livroRemovido); // Retorna 200 com o livro removido
        }
    }
}