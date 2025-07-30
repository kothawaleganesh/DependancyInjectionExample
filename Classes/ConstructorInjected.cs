namespace DIExample.Classes
{
    public class ConstructorInjected
    {
        private readonly IMessageService _messageService;

        public ConstructorInjected(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public void Run()
        {
            _messageService.Send("Constructor injected");
        }
    }
}
