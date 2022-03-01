using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_1
{
    public class ObserverA: IObserver
    {
       public void Update(ISubject subject)
       {
            Console.WriteLine("Наблюдатель A получил сообщение: {0}", (subject as Countdown).message);     
       }
    }
}
