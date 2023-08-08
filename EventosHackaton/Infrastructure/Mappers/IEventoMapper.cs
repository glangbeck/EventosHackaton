using EventosHackaton.Models.Domain;

namespace EventosHackaton.Infrastructure.Mappers
{
	public interface IEventoMapper
	{
		EventoApiModel Map(Evento evento);
	}
}
