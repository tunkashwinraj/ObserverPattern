using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_1262774
{
    interface IObserver // observer is the client i.e., subscriber
    {
        void Notify(StockInfo sinfo);
    }
}
