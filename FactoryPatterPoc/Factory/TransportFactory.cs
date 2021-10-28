using System;
using System.Threading;
using FactoryPatterPoc.Entities.Aggregations.ShipAgg;
using FactoryPatterPoc.Entities.Aggregations.TruckAgg;
using FactoryPatterPoc.Entities.Enumerations;
using FactoryPatterPoc.Factory.Contracts;
using FactoryPatterPoc.Factory.Entities.Contracts;

namespace FactoryPatterPoc.Factory
{
    public class TransportFactory : ITransportFactory
    {
        private static TransportFactory _transportFactory;
        private static readonly object _sync = new object();
        
        private TransportFactory()
        { }

        public static TransportFactory GetInstance()
        {
            lock (_sync)
            {
                if (_transportFactory is null)
                {
                    return _transportFactory = new TransportFactory();  
                }

                return _transportFactory;
            }
        }
        
        public ITransport CreateTransport(string transportOption)
        {
            return transportOption.ToLower() switch
            {
                TransportTypes.Truck => new Truck(),
                TransportTypes.Ship => new Ship(),
                _ => throw new NotImplementedException(
                    $"This transport option is not implemented yet, available options: { string.Join(", ", TransportTypes.GetValues()) }")
            };
        }
    }
}
