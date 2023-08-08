using System;

namespace EventosHackaton.Models.Domain
{
	public class EventoApiModel
	{
		public string Titulo { get; set; }

		public string Descricao { get; set; }

		public string Local { get; set; }

		public DateTime Data { get; set; }

		public DateTime HoraInicio { get; set; }

		public DateTime HoraTermino { get; set; }

		public byte TipoEvento { get; set; }

		public int Anexo { get; set; }
	}
}
