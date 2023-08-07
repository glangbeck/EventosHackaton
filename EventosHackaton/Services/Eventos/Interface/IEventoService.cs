using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventosHackaton.Services.Eventos.Interface
{
	public interface IEventoService
	{
		void CadastrarEvento(Evento evento);
	}
}
