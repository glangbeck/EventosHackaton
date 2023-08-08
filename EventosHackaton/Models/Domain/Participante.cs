using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Collections.Generic;

namespace EventosHackaton.Models.Domain
{
    public class Participante
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public Dictionary<ObjectId, double> SaldoEvento { get; set; } //{idEvento, saldoEvento}

        public Participante()
        {
            this.Id = ObjectId.GenerateNewId();
        }
    }
}
