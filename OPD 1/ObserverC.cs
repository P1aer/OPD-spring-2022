using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_1
{
    public class ObserverC:IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("Наблюдатель C получил сообщение вот его начало: {0}...", (subject as Countdown).message.Substring(0,3));
        }
    }
}
