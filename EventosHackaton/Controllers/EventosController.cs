using EventosHackaton.Infrastructure.Mappers;
using EventosHackaton.Models.Domain;
using EventosHackaton.Services.Eventos.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EventosHackaton.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class EventosController : ControllerBase
	{
		private readonly IEventoService _eventoService;
		private readonly IEventoMapper _eventoMapper;


		public EventosController(IEventoService eventoService, IEventoMapper eventoMapper)
		{
			_eventoService = eventoService;
			_eventoMapper = eventoMapper;
		}

		[HttpPost("[action]")]
		public ActionResult Listar()
		{
			return Ok(_eventoMapper.Map(_eventoService.Listar()));
		}

		[HttpPost("[action]")]
		public ActionResult Cadastrar([FromBody] EventoApiModel eventoApiModel)
		{
			var evento = _eventoMapper.Map(eventoApiModel);
			var inclusao = _eventoService.Incluir(evento, out var mensagem);
			//if (!inclusao) return 

			return Ok();
		}

		[HttpPost("[action]")]
		public ActionResult Atualizar([FromBody] EventoApiModel eventoApiModel)
		{
			var evento = _eventoMapper.Map(eventoApiModel);
			var alteracao = _eventoService.Alterar(evento, out var mensagem);

			return Ok();
		}
	}
}
