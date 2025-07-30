namespace DIExample.Classes
{
    public class PropertyInjected
    {
        public IMessageService _iMessageService { get; set; }
        public void Run()
        {
            _iMessageService?.Send("Property Injection");
        }
    }
}
