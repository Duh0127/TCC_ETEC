using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using ApiTcc.Data;
using ApiTcc.Models;
using ApiTcc.Models.Enuns;
using BACK.Models.Enuns;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiTcc.Controllers
{
    //[Authorize(Roles = "Associado")]
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {

        private readonly DataContext _context;

        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProdutosController(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> ProdutoExistente (string codigoProduto)
        {
            if(await _context.Produtos.AnyAsync(x => x.codigoProduto.ToLower() == codigoProduto.ToLower()))
            {
                return true;
            }
            return false;
        }

        private int ObterUsuarioId()
        {
            return int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        }

        private string ObterPerfilUsuario()
        {
            return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Produto> lista = await _context.Produtos.OrderByDescending(p => p.produtoId).ToListAsync();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Produto pd = await _context.Produtos
                    .Include(a => a.Associado).FirstOrDefaultAsync(pdBusca => pdBusca.produtoId == id);

                return Ok(pd);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }           
        }

        [HttpGet("GetByUser")]
        
        public async Task<IActionResult> GetByUserAsync()
        {
            try
            {
                int id = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);

                List<Produto> lista = await _context.Produtos
                    .Where(a => a.associadoId == id).ToListAsync();

                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByPerfil")]
        
        public async Task<IActionResult> GetByPerfilAsync()
        {
            try
            {
                List<Produto> lista = new List<Produto>();

                if(ObterPerfilUsuario() == "Admin")
                    lista = await _context.Produtos.ToListAsync();
                else
                {
                    lista = await _context.Produtos.Where(p => p.Associado.associadoId == ObterUsuarioId()).ToListAsync();
                }

                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByCategoria/{categoriaId}")]
        
         public async Task<IActionResult> GetByCategoria(int categoriaId)
         {
             try
            {
                List<Produto> listaFinal = await _context.Produtos
                .Where(p => p.categoriaProduto == (CategoriaEnum)categoriaId)
                .OrderByDescending(p => p.produtoId).ToListAsync();

                if(listaFinal.Count == 0)
                    return NotFound("Nenhum produto encontrado.");
                
                return Ok(listaFinal);
            }
            catch (System.Exception)
            {
                
                throw;
            }
         }


        [HttpPost]
        public async Task<IActionResult> Add(Produto novoProduto)
        {

             try
             {
                 if (await ProdutoExistente(novoProduto.codigoProduto))
                     throw new System.Exception("Código de produto já existe");

                novoProduto.Associado = _context.Associados.FirstOrDefault(aBusca => aBusca.associadoId == ObterUsuarioId());


                // int associadoId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                // novoProduto.Associado = _context.Associados.FirstOrDefault(aBusca => aBusca.associadoId == associadoId);
                

                //INSERIR FORNECENDO ID DO USUARIO
                //  Associado a = await _context.Associados
                //      .FirstOrDefaultAsync(a => a.associadoId == novoProduto.associadoId);

                //  if(a == null)
                //      throw new System.Exception("Não existe Associado com o Id Informado.");
                
                await _context.Produtos.AddAsync(novoProduto);
                await _context.SaveChangesAsync();

                return Ok(novoProduto.produtoId);
             }
                catch (Exception ex)
                {
                
                 return BadRequest(ex.InnerException);
                }
        }

        // [HttpPut]
        // public async Task<IActionResult> Update(Produto p)
        // {
        //     Produtos produtosAlterado = persoagens.Find(produto => produto.Id)
        // }

         [HttpPut]
         public async Task<IActionResult> Update(Produto novoProduto)
         {
             try
             {
                 if (novoProduto.nomeProduto == "" && novoProduto.precoProduto == 0)
                 {
                     throw new Exception("Campos Nome e Preço não podem estar vazios!");
                }

                 novoProduto.Associado = _context.Associados.FirstOrDefault(aBusca => aBusca.associadoId == ObterUsuarioId());
                 // int associadoId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                 // novoProduto.Associado = _context.Associados.FirstOrDefault(aBusca => aBusca.associadoId == associadoId);
                
                 _context.Produtos.Update(novoProduto);
                 int linhasAfestadas = await _context.SaveChangesAsync();

                 return Ok(linhasAfestadas);
             }
             catch (Exception ex)
             {
                
                 return BadRequest(ex.Message);
             }
         }

      
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
               Produto pdRemover = await _context.Produtos
                .FirstOrDefaultAsync(pd => pd.produtoId == id);

                _context.Produtos.Remove(pdRemover);
                int linhasAfestadas = await _context.SaveChangesAsync();

                return Ok(linhasAfestadas);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }




    }
}