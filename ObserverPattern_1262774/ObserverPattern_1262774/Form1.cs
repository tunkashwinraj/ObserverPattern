using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern_1262774
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObserver_Click(object sender, EventArgs e)
        {
            ConcreteStockSubjectGoogle csgoog = new
           ConcreteStockSubjectGoogle();
            ConcreteObserver co1 = new ConcreteObserver("Bill");
            csgoog.AddObserver(co1);
            ConcreteObserver co2 = new ConcreteObserver("Sally");
            csgoog.AddObserver(co2);
            csgoog.UpdatePrice(7.50);
        }
    }
}
