using EventosHackaton.Infrastructure.Mappers;
using EventosHackaton.Models.Domain;
using EventosHackaton.Services.Eventos.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
		public List<EventoApiModel> Listar()
		{
			return _eventoMapper.Map(_eventoService.Listar()).ToList();
		}

		[HttpPost("[action]")]
		public EventoApiModel Obter(int codigoEvento)
		{
			return _eventoMapper.Map(_eventoService.Obter(codigoEvento));
		}

		[HttpPost("[action]")]
		public RetornoApi Cadastrar([FromBody] EventoApiModel eventoApiModel)
		{
			var evento = _eventoMapper.Map(eventoApiModel);
			var inclusao = _eventoService.Incluir(evento, out var mensagem);

			return new RetornoApi { Sucesso = inclusao, MensagemErro = mensagem };
		}

		[HttpPost("[action]")]
		public RetornoApi Atualizar([FromBody] EventoApiModel eventoApiModel)
		{
			var evento = _eventoMapper.Map(eventoApiModel);
			var alteracao = _eventoService.Alterar(evento, out var mensagem);

			return new RetornoApi { Sucesso = alteracao, MensagemErro = mensagem };
		}

		[HttpPost("[action]")]
		public RetornoApi Excluir(int codigoEvento)
		{
			var exclusao = _eventoService.Excluir(codigoEvento, out var mensagem);
			return new RetornoApi { Sucesso = exclusao, MensagemErro = mensagem };
		}
	}
}
