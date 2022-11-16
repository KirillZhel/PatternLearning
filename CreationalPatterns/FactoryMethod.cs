namespace CreationalPatterns
{
    public interface ITransport
    {
        public Guid TransportId { get; set; }
        public string Deliver(string start, string end);
    }

    public class Car : ITransport
    {
        public Guid TransportId { get; set; }

        public Car()
        {
            TransportId = Guid.NewGuid();
        }

        public string Deliver(string start, string end)
        {
            return $"{nameof(Car)} with ID \"{TransportId}\" start: {start}, end: {end}";
        }
    }

    public class Ship : ITransport
    {
        public Guid TransportId { get; set; }

        public Ship()
        {
            TransportId = Guid.NewGuid();
        }

        public string Deliver(string start, string end)
        {
            return $"{nameof(Ship)} with ID \"{TransportId}\" start: {start}, end: {end}";
        }
    }

    public abstract class TransportLogistics
    {
        public void PlanDelivery(string start, string end)
        {
            ITransport t = CreateTransport();
            Console.WriteLine(t.Deliver(start, end));
        }

        public abstract ITransport CreateTransport();
    }

    public class CarLogistics : TransportLogistics
    {
        public override ITransport CreateTransport()
        {
            return new Car();
        }
    }

    public class ShipLogistics : TransportLogistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
