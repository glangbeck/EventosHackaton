using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventosHackaton.Models.Domínio
{
	public class EventoApiModel
	{
		public string Titulo { get; set; }

		public string Descricao { get; set; }

		public string Local { get; set; }

		public DateTime Data { get; set; }

		public DateTime HoraInicio { get; set; }

		public DateTime HoraTermino { get; set; }
	}
}
