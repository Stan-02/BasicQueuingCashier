using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BasicQueuingCashier
{
    public partial class CashierWindowsQueueForm : Form
    {
        public CashierWindowsQueueForm()
        {
            InitializeComponent();

        }

        private void CashierWindowsQueueForm_Load(object sender, EventArgs e)
        {

        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer timing = new Timer();
            timing.Interval = (1 * 1000);
            timing.Tick += new EventHandler(btnRefresh_Click);
            timing.Start();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CashierClass.CashierQueue.Dequeue();
        }
    }
}
