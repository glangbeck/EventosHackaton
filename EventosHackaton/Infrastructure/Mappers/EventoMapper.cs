using EventosHackaton.Models.Domain;
using System.Collections.Generic;
using System.Linq;

namespace EventosHackaton.Infrastructure.Mappers
{
	public class EventoMapper : IEventoMapper
	{
		public Evento Map(EventoApiModel eventoApiModel)
		{
			return new Evento
			{
				Id = eventoApiModel.Id,
				Titulo = eventoApiModel.Titulo,
				Descricao = eventoApiModel.Descricao,
				DataInicio = eventoApiModel.DataInicio,
				HoraInicio = eventoApiModel.HoraInicio,
				Local = eventoApiModel.Local,
				TipoEvento = (byte) eventoApiModel.TipoEvento,
				Anexo = eventoApiModel.Anexo
			};
		}

		public EventoApiModel Map(Evento evento)
		{
			return new EventoApiModel
			{
				Id = evento.Id,
				Titulo = evento.Titulo,
				Descricao = evento.Descricao,
				DataInicio = evento.DataInicio,
				HoraInicio = evento.HoraInicio,
				Local = evento.Local,
				TipoEvento = (TipoEvento) evento.TipoEvento,
				Anexo = evento.Anexo
			};
		}

		public IEnumerable<EventoApiModel> Map(List<Evento> eventoSet)
		{
			return eventoSet.Select(Map);
		}
	}
}
