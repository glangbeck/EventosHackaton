using EventosHackaton.Models.Domain;
using MongoDB.Bson;
using System.Collections.Generic;

namespace EventosHackaton.Infrastructure.Data
{
    public interface IParticipanteRepositorio
    {
        bool Cadastrar(Evento evento, out string message);
        Participante GetByName(string name);
        Participante GetByCPF(string cpf);
        List<Participante> GetAll();
        bool GetSaldoEvento(ObjectId objectId, out string message);
        bool UpdateSaldoEvento(ObjectId objectId, out string message);
        bool Update(Evento evento, out string message);
        bool Delete(Evento evento, out string message);
    }
}
