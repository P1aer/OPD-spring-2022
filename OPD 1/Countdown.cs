using System;
using System.Collections.Generic;
using System.Threading;

namespace OPD_1
{
    public class Countdown:ISubject 
    {
        public string message { get; private set; } = "";

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer); 
        }
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        public void SendMessages(string message, int time)
        {
            this.message = message;
            Thread.Sleep(1000*time);
            Notify();
        }
    }
}
