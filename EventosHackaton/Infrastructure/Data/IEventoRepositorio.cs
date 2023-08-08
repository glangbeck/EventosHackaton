using EventosHackaton.Models.Domain;
using System;
using System.Collections.Generic;

namespace EventosHackaton.Infrastructure.Data
{
    public interface IEventoRepositorio
    {
        bool CadastrarEvento(Evento evento);
        Evento GetEvento(string titulo);
        List<Evento> GetEventos();
        bool UpdateEvento(Evento evento);
        bool DeleteEvento(Evento evento);
    }
}
