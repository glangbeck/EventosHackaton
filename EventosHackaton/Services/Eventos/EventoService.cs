using EventosHackaton.Models.Domain;
using EventosHackaton.Services.Eventos.Interface;
using System;
using System.Collections.Generic;

namespace EventosHackaton.Services.Eventos
{
	public class EventoService : IEventoService
	{
		public EventoService()
		{}

		public List<Evento> Listar()
		{
			throw new NotImplementedException();
		}

		public Evento Obter(int codigo)
		{
			throw new NotImplementedException();
		}

		public bool Incluir(Evento evento, out string mensagem)
		{
			throw new NotImplementedException();
		}

		public bool Alterar(Evento evento, out string mensagem)
		{
			throw new NotImplementedException();
		}

		public bool Excluir(int codigo, out string mensagem)
		{
			throw new NotImplementedException();
		}

		private bool ValidarDados(Evento evento)
		{
			if (string.IsNullOrWhiteSpace(evento.Titulo))
			{
				return false;
			}
			if (string.IsNullOrWhiteSpace(evento.Local))
			{
				return false;
			}
			return true;
		}
	}
}
