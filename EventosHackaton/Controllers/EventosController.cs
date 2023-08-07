using EventosHackaton.Models.Domínio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventosHackaton.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class EventosController : ControllerBase
	{
		private readonly ILogger<EventosController> _logger;
		

		public EventosController(ILogger<EventosController> logger)
		{
			_logger = logger;
		}

		[HttpPost]
		public IEnumerable<Evento> Cadastrar(EventoApiModel eventoApiModel)
		{
			
		}
	}
}
