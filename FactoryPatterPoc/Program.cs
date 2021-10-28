using System;
using System.Security.Cryptography;
using System.Threading;
using FactoryPatterPoc.Entities.Enumerations;
using FactoryPatterPoc.Factory;
using FactoryPatterPoc.Factory.Entities.Contracts;

namespace FactoryPatterPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(LoadInstance) { Name = "Thread1" };
            Thread thread2 = new Thread(LoadInstance) { Name = "Thread2" };
            Thread thread3 = new Thread(LoadInstance) { Name = "Thread3" };
            
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        static void LoadInstance()
        {
            for (int i = 0; i < 5; i++)
            {
                var transportFactory = TransportFactory.GetInstance();

                try
                {
                    var transport1 = transportFactory.CreateTransport(TransportTypes.Truck);
                    transport1.Deliver();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
