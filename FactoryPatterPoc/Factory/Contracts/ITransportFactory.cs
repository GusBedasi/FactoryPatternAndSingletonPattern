using FactoryPatterPoc.Factory.Entities.Contracts;

namespace FactoryPatterPoc.Factory.Contracts
{
    public interface ITransportFactory
    {
        ITransport CreateTransport(string transportType);
    }
}
