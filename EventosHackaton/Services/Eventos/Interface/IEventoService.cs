using EventosHackaton.Models.Domain;

namespace EventosHackaton.Services.Eventos.Interface
{
	public interface IEventoService
	{
		void CadastrarEvento(Evento evento);
	}
}
