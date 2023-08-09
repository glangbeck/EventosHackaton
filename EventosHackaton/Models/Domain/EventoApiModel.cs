using System;

namespace EventosHackaton.Models.Domain
{
	public class EventoApiModel
	{
		public int Id { get; set; }

		public string Titulo { get; set; }

		public string Descricao { get; set; }

		public string Local { get; set; }

		public DateTime DataInicio { get; set; }

		public DateTime HoraInicio { get; set; }

		public TipoEvento TipoEvento { get; set; }

		public int Anexo { get; set; }

		public int? LimitePessoas { get; set; }
	}
}
