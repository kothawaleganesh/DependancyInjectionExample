using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample.Classes
{
    public class MethodInjected
    {
        public void Run(IMessageService service)
        {
            service.Send("Method Injection");
        }
    }
}
