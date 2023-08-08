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

		[HttpPost]
		public ActionResult Cadastrar(EventoApiModel eventoApiModel)
		{
			var evento = _eventoMapper.Map(eventoApiModel);
			_eventoService.CadastrarEvento(evento);

			return Ok();
		}
	}
}
