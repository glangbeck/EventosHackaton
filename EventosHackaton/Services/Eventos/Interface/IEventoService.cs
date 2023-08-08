using EventosHackaton.Models.Domain;
using System.Collections.Generic;

namespace EventosHackaton.Services.Eventos.Interface
{
	public interface IEventoService
	{
		List<Evento> Listar();
		Evento Obter(int codigo);
		bool Incluir(Evento evento, out string mensagem);
		bool Alterar(Evento evento, out string mensagem);
		bool Excluir(int codigo, out string mensagem);
	}
}
