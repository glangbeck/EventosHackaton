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
		

		public EventosController(IEventoService eventoService)
		{
			_eventoService = eventoService;
		}

		[HttpPost]
		public IEnumerable<Evento> Cadastrar(EventoApiModel eventoApiModel)
		{
			return null;
		}
	}
}
