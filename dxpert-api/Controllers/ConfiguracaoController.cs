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
        public Task<IEnumerable<Configuracoes>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] string value)
        {
            try
            {
                _service.Update(id, value);
                return Ok();
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
