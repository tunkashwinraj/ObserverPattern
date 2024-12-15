using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern_1262774
{
    class ConcreteObserver : IObserver
    {
        public ConcreteObserver(string nm)
        {
            clientName = nm;
        }
        string clientName;

 public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public void Notify(StockInfo sinfo)
        {
            MessageBox.Show("Notification sent to : " + clientName + "\n" +
            sinfo.ToString());
        }
    }
}
