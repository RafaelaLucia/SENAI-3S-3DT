using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoInternoAPI.Domains;
using ProjetoInternoAPI.Interfaces;
using ProjetoInternoAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInternoAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private IProdutoRepository _pdRepository { get; set; }
        public ProdutosController()
        {
            _pdRepository = new ProdutoRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_pdRepository.ListarTodas());
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            try
            {
                _pdRepository.Cadastrar(produto);
                return StatusCode(201);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpDelete("{idProduto}")]
        public IActionResult Deletar(int idProduto)
        {
            try
            {
                _pdRepository.Deletar(idProduto);
                return StatusCode(204);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("{idProduto}")]
        public IActionResult BuscarPorId(int idProduto)
        {
            try
            {
                return Ok(_pdRepository.BuscarPorId(idProduto));
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

    }
}
