using EventosHackaton.Models.Domain;
using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace EventosHackaton.Infrastructure.Data
{
    public interface IEventoRepositorio
    {
        bool Cadastrar(Evento evento, out string message);
        Evento GetByTitle(string titulo);
        List<Evento> GetAll();
        bool Update(Evento evento, out string message);
        bool Delete(ObjectId objectId, out string message);
    }
}
