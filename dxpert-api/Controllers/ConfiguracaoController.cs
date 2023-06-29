using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace dxpert_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfiguracaoController : ControllerBase
    {
        private readonly IConfiguracaoService _service;

        public ConfiguracaoController(IConfiguracaoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpPut()]
        public async Task<IActionResult> Update([FromBody] Configuracoes config)
        {
            try
            {
                await _service.Update(config.Id, config.Valor);
                return Ok();
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
