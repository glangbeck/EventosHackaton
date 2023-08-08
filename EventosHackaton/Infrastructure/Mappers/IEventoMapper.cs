using EventosHackaton.Models.Domain;

namespace EventosHackaton.Infrastructure.Mappers
{
	public interface IEventoMapper
	{
		Evento Map(EventoApiModel eventoApiModel);
	}
}
