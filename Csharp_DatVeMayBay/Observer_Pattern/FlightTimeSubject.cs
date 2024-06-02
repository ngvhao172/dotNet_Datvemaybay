using Csharp_DatVeMayBay.Models.Domain;

namespace Csharp_DatVeMayBay.Observer_Pattern
{
    public class FlightTimeSubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public FlightTimeSubject() { }

        public void Register(IObserver observer)
        {
            if(!observers.Contains(observer))
                observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(Flight flight)
        {
            foreach (var observer in observers)
            {
                observer.Update(flight);
            }
        }
    }
}

