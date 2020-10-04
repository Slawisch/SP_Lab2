using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Lab2
{
    public partial class Form1 : Form
    {
        Factory fc = new Factory();
        public Form1()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            factoryName.Text = fc.Name;
            workersNum.Value = fc.Workers;
            mastersNum.Value = fc.Masters;
        }
    }
}