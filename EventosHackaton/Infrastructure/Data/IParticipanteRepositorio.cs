using EventosHackaton.Models.Domain;
using MongoDB.Bson;
using System.Collections.Generic;

namespace EventosHackaton.Infrastructure.Data
{
    public interface IParticipanteRepositorio
    {
        bool CadastrarParticipante(Evento evento);
        Participante GetParticipanteByName();
        Participante GetParticipanteByCPF();
        List<Participante> GetParticipantes();
        bool GetSaldoEvento(ObjectId objectId);
        bool UpdateSaldoEvento(ObjectId objectId);
        bool UpdateParticipante(Evento evento);
        bool DeleteParticipante(Evento evento);
    }
}
