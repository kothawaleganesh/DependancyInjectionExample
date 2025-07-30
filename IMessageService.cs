namespace DIExample
{
    public interface IMessageService
    {
        Guid Id { get; }
        void Send(string message);
    }

    public class TransientMessageService : IMessageService
    {
        public Guid Id { get; } = Guid.NewGuid();

        public void Send(string message)
        {
            Console.WriteLine($"{Id} : {message}");
        }
    }
}
