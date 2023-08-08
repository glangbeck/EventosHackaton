using System;

namespace EventosHackaton.Models.Domain
{
	public class Evento
	{
		public int Id { get; set; }

		public string Titulo { get; set; }

		public string Descricao { get; set; }

		public string Local { get; set; }

		public DateTime DataInicio { get; set; }

		public DateTime HoraInicio { get; set; }

		public byte TipoEvento { get; set; }

		public int Anexo { get; set; }
	}
}
