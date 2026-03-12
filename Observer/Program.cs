public interface IObserver
{
    void Notify(string message);
}

public class Observer : IObserver
{
    public string Name { get; }

    public Observer(string name)
    {
        Name = name;
    }

    public void Notify(string message)
    {
        Console.WriteLine($"{Name} received message: {message}");
    }
}
public class Publisher
{
    public string Name { get; }
    private List<IObserver> _subscribers = new List<IObserver>();

    public Publisher(string name)
    {
        Name = name;
    }

    public void Subscribe(IObserver observer)
    {
        if (!_subscribers.Contains(observer))
        {
            _subscribers.Add(observer);
        }
    }

    public void Unsubscribe(IObserver observer)
    {
        _subscribers.Remove(observer);
    }

    public void NotifySubscribers(string message)
    {
        foreach (var observer in _subscribers)
        {
            observer.Notify(message);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Publisher publisher = new Publisher("Pääjulkaisija");

        Observer obs1 = new Observer("Tilaaja 1");
        Observer obs2 = new Observer("Tilaaja 2");

        publisher.Subscribe(obs1);
        publisher.Subscribe(obs2);

        Console.WriteLine("Lähetetään viesti kaikille:");
        publisher.NotifySubscribers("Hei tilaajat!");

        publisher.Unsubscribe(obs1);

        Console.WriteLine("\nLähetetään uusi viesti (Tilaaja 1 poistettu):");
        publisher.NotifySubscribers("Vain toiselle tilaajalle.");
    }
}