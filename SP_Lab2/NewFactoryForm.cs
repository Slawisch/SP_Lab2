using System;
using System.Windows.Forms;

namespace SP_Lab2
{
    public partial class NewFactoryForm : Form
    {
        public Factory NewFactory { get; private set; }
        public NewFactoryForm()
        {
            InitializeComponent();
        }

        private void AddClicked(object sender, EventArgs e)
        {
            NewFactory = new Factory (tbName.Text, (int)numWSalary.Value, (int)numMSalary.Value, (int)numWProfit.Value, (int)numMProfit.Value);
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}