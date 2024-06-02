using Csharp_DatVeMayBay.Models.Domain;

namespace Csharp_DatVeMayBay.Observer_Pattern
{
    public interface IObserver
    {
        void Update(Flight flight);
    }
}
