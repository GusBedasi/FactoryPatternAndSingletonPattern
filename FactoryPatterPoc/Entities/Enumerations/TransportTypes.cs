using System.Collections.Generic;

namespace FactoryPatterPoc.Entities.Enumerations
{
    public static class TransportTypes
    {
        public const string Truck = "truck";
        public const string Ship = "ship";

        public static IEnumerable<string> GetValues()
        {
            yield return Truck;
            yield return Ship;
        }
    }
}
