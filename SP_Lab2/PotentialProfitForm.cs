using System;
using System.Windows.Forms;

namespace SP_Lab2
{
    public partial class PotentialProfitForm : Form
    {
        private Factory _factory;
        public PotentialProfitForm(Factory factory)
        {
            _factory = factory;
            InitializeComponent();
        }

        private void CalculateClicked(object sender, EventArgs e)
        {
            int needWorkers;
            int needMasters;
            numProfit.Value = _factory.ProfitBySum((int)numExpenses.Value, out needWorkers, out needMasters);
            numMasters.Value = needMasters;
            numWorkers.Value = needWorkers;
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}