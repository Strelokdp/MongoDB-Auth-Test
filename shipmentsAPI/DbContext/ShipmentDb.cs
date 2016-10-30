using MongoDB.Driver;
using shipmentsAPI.Models;

namespace shipmentsAPI.DBContext
{
    public class ShipmentDb
    {
        public static MongoCollection<Shipment> Open()
        {
            var client = new MongoClient("mongodb://localhost");
            var server = client.GetServer();
            var db = server.GetDatabase("ShipmentDb");
            return db.GetCollection<Shipment>("Shipments");
        }
    }
}