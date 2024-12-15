using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_1262774
{
    class StockSubject // base subject class
    {
        List<IObserver> OBList = new List<IObserver>();
        StockInfo stockInfo = null;
        public StockSubject(StockInfo sinfo)
        {
            stockInfo = sinfo;
        }
        public void UpdatePrice(double updateAmt)
        {
            stockInfo.Price = stockInfo.Price + updateAmt;
            // notify observers i.e., subscribers
            foreach (IObserver observer in OBList)
                observer.Notify(stockInfo); // send state of stock
        }
        public void AddObserver(IObserver obs)
        {
            OBList.Add(obs);
        }
        public void RemoveObserver(IObserver obs)
        {
            OBList.Remove(obs);
        }
    }
}
