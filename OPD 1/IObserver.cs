using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_1
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
