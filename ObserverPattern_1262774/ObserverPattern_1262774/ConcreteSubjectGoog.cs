using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_1262774
{
    class ConcreteStockSubjectGoogle : StockSubject
    {
        public ConcreteStockSubjectGoogle() :
        base(new StockInfo("Goog", 585))
        {
        }
    }

}
