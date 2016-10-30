using MongoDB.Driver;
using shipmentsAPI.DBContext;
using shipmentsAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace shipmentsAPI.Controllers
{
    public class ShipmentsController : ApiController
    {
        MongoCollection<Shipment> _shipments;

        public ShipmentsController()
        {
            _shipments = ShipmentDb.Open();
        }


        public IEnumerable<Shipment> Get()
        {
            return _shipments.FindAll();
        }

    }
}
