using EventosHackaton.Models.Domain;
using System.Collections.Generic;

namespace EventosHackaton.Infrastructure.Mappers
{
	public interface IEventoMapper
	{
		Evento Map(EventoApiModel eventoApiModel);

		EventoApiModel Map(Evento evento);

		IEnumerable<EventoApiModel> Map(List<Evento> eventoSet);
	}
}
