using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace dxpert_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private readonly ICadastroService _cadastroService;

        public CadastroController(ICadastroService cadastroService)
        {
            _cadastroService = cadastroService ?? throw new ArgumentNullException(nameof(cadastroService));
        }

        [HttpPut]
        public async Task<IActionResult> AddOrUpdate(Cadastro cadastro)
        {
            var data = await _cadastroService.AddOrUpdate(cadastro);
            var mensagem = data.Id != default ? "Sucesso" : "Erro";
            mensagem += " ao atualiziar/inserir o cadastro";
            return Ok(new CadastroResponse()
            {
                Cadastro = data,
                Mensagem = mensagem,
                Sucesso = data.Id != default
            });
        }

        [HttpPost]
        public async Task<IActionResult> AddDescendentes(DescendentesRequest req)
        {
            var data = await _cadastroService.AddDescendentes(req);
            
            var mensagem = data ? "Sucesso" : "Erro";
            mensagem += " ao atualiziar/inserir o cadastro";
            return Ok(new CadastroResponse()
            {
                Cadastro = null,
                Mensagem = mensagem,
                Sucesso = data
            });
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var data = await _cadastroService.List();
            var mensagem = data != null ? "Sucesso" : "Erro";
            mensagem += " ao atualiziar/inserir o cadastro";
            return Ok(new CadastroListResponse()
            {
                Cadastros = data,
                Mensagem = mensagem,
                Sucesso = true
            });
        } 
        
        
        [HttpGet]
        public async Task<IActionResult> Acompanhamentos(int? idUser)
        {
            var data = await _cadastroService.ListAcompanhamentos(idUser);
            return Ok(data);
        }
    }
}
