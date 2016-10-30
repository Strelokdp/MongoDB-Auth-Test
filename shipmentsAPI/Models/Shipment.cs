using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace shipmentsAPI.Models
{
    public class Shipment
    {
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
    }
}

