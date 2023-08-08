using EventosHackaton.Models.Domain;
using System;

namespace EventosHackaton.Infrastructure.Mappers
{
	public class EventoMapper : IEventoMapper
	{
		public Evento Map(EventoApiModel eventoApiModel)
		{
			return new Evento
			{
				Titulo = eventoApiModel.Titulo,
				Descricao = eventoApiModel.Descricao,
				DataHoraInicio = eventoApiModel.Data + eventoApiModel.HoraInicio.TimeOfDay,
				DataHoraTermino = eventoApiModel.Data + eventoApiModel.HoraTermino.TimeOfDay,
				Local = eventoApiModel.Local,
				TipoEvento = (byte) eventoApiModel.TipoEvento,
				Anexo = eventoApiModel.Anexo
			};
		}
	}
}
