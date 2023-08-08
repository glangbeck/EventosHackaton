using EventosHackaton.Models.Domain;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace EventosHackaton.Infrastructure.Data.MongoDB
{
    public class EventosMongoDbRepositorio: IEventoRepositorio
    {
        private readonly string connectionString = "mongodb://augusto-rengel:LuntToSiafu5FsdMmHpVe5mrEhgbbWUSt0dZ8Pw7IUqQ8EB54TFGcMsxfDRQSVSQIIHUbGMom382ACDbXq84Fw==@augusto-rengel.mongo.cosmos.azure.com:10255/?ssl=true&replicaSet=globaldb&retrywrites=false&maxIdleTimeMS=120000&appName=@augusto-rengel@";

        public MongoClient MongoClient { get; set; }
        public IMongoCollection<Evento> EventosCollection { get; set; }
        public EventosMongoDbRepositorio()
        {
            var client = new MongoClient(connectionString);

            EventosCollection = client.GetDatabase("testeHackathonDb").GetCollection<Evento>("eventos");
        }

        public bool Cadastrar(Evento evento, out string message)
        {
            try
            {
                EventosCollection.InsertOne(evento);
                message = string.Empty;
                return true;
            }
            catch(Exception ex)
            {
                message = ex.ToString();
                return false;
            }
        }

        public Evento GetByTitle(string titulo)
        {
            var filter = Builders<Evento>.Filter.Eq("titulo", titulo);
            return EventosCollection.Find(filter).FirstOrDefault();
        }

        public List<Evento> GetAll()
        {
            List<Evento> eventos = EventosCollection.Find(new BsonDocument()).ToList();
            return eventos;
        }

        public bool Update(Evento evento, out string message)
        {
            try
            {
                var filter = Builders<Evento>.Filter.Eq("_id", evento.Id);
                EventosCollection.ReplaceOne(filter, evento);
                message = string.Empty;
                return true;
            }
            catch(Exception ex)
            {
                message = ex.ToString();
                return false;
            }
        }

        public bool Delete(ObjectId id, out string message)
        {
            try
            {
                var filter = Builders<Evento>.Filter.Eq("_id", id);
                EventosCollection.DeleteOne(filter);
                message = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                message = ex.ToString();
                return false;
            }
        }
    }
}
