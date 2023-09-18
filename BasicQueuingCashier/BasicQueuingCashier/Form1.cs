namespace BasicQueuingCashier
{
    public partial class QueuingForm : Form
    {
        CashierClass cashier;

        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {
            CashierWindowsQueueForm form = new CashierWindowsQueueForm();
            form.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }


    }
}