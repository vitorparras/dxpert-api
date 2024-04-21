﻿using Domain.DTO.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace API.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(UsuarioRequest usuario)
        {
            var response = await _usuarioService.AddAsync(usuario);
            response.Sucesso = response.Id != null;
            response.Mensagem = response.Id != null ? "Sucesso" : "Erro";
            response.Mensagem += " ao Adicionar Usuario ";

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(UsuarioRequest usuario)
        {
            var response = await _usuarioService.UpdateAsync(usuario);
            response.Sucesso = response.Id != null;
            response.Mensagem = response.Id != null ? "Sucesso" : "Erro";
            response.Mensagem += " ao Alterar Usuario ";
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _usuarioService.DeleteAsync(id);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Find(int id)
        {
            var response = await _usuarioService.GetByIdAsync(id);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var response = await _usuarioService.GetAllAsync();
            return Ok(response);
        }
    }
}
