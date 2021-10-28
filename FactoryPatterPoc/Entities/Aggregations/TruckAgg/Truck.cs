using System;
using FactoryPatterPoc.Factory.Entities.Contracts;

namespace FactoryPatterPoc.Entities.Aggregations.TruckAgg
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivery truck");
        }
    }
}
