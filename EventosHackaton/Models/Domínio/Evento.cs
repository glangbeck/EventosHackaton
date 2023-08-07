using System;

namespace EventosHackaton
{
	public class Evento
	{
		public int Id { get; set; }

		public string Titulo { get; set; }

		public string Descricao { get; set; }

		public string Local { get; set; }

		public DateTime DataHoraInicio { get; set; }
	}
}
