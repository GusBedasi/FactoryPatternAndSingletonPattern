using System;
using FactoryPatterPoc.Factory.Entities.Contracts;

namespace FactoryPatterPoc.Entities.Aggregations.ShipAgg
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivery ship");
        }
    }
}
