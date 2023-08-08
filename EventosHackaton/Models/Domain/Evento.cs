using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EventosHackaton.Models.Domain
{
	public class Evento
	{
        [BsonId]
        public ObjectId Id { get; set; }

		public string Titulo { get; set; }

		public string Descricao { get; set; }

		public string Local { get; set; }

		public DateTime DataInicio { get; set; }

		public DateTime HoraInicio { get; set; }

		public byte TipoEvento { get; set; }

		public int Anexo { get; set; }

        public Evento()
        {
            this.Id = ObjectId.GenerateNewId();
        }
    }
}
