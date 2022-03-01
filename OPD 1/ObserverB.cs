using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_1
{
    public class ObserverB:IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("Наблюдатель B получил сообщение длиной {0} символов", (subject as Countdown).message.Length);
        }
    }
}
