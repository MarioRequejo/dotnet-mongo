using System;
using MongoDB.Driver.GeoJsonObjectModel;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Api.Data.Collections
{
    public class Infectado
    {
        public Infectado(DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }

        public Infectado(string codigoPaciente, string sexo){
            this.CodigoPaciente = codigoPaciente;
            this.Sexo = sexo;
        }
        
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CodigoPaciente { get; set; }
    }
}