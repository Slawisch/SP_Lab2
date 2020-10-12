using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SP_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListBox()
        {
            var selectedIndices = listBox1.SelectedIndices.Cast<int>().ToList();
            listBox1.Items.Clear();
            for (int i = 0; i < Factories.Length; i++)
            {
                listBox1.Items.Add(Factories.GetFactoryByIndex(i));
            }
            listBox1.Update();
            foreach (var item in selectedIndices)
            {
                listBox1.SetSelected(item, true);
            }
        }

        private void DeleteClicked(object sender, EventArgs e)
        {
            int delIndex = listBox1.SelectedIndex;
            if (delIndex >= 0 && delIndex < Factories.Length)
            {
                Factories.DeleteFactory(delIndex);
                UpdateListBox();
            }
        }

        private void LbDoubleClicked(object sender, EventArgs e)
        {
            
        }

        private void HireWorkerClicked(object sender, EventArgs e)
        {
            int hireWIndex = listBox1.SelectedIndex;
            if (hireWIndex >= 0 && hireWIndex < Factories.Length)
            {
                Factories.GetFactoryByIndex(hireWIndex).HireWorker();
                UpdateListBox();
            }
        }

        private void HireMasterClicked(object sender, EventArgs e)
        {
            int hireMIndex = listBox1.SelectedIndex;
            if (hireMIndex >= 0 && hireMIndex < Factories.Length)
            {
                Factories.GetFactoryByIndex(hireMIndex).HireMaster();
                UpdateListBox();
            }
        }

        private void DismissWorkerClicked(object sender, EventArgs e)
        {
            int dismissWIndex = listBox1.SelectedIndex;
            if (dismissWIndex >= 0 && dismissWIndex < Factories.Length)
            {
                var factory = Factories.GetFactoryByIndex(dismissWIndex);
                if(factory.Workers > 0)
                    factory.DismissWorker();
                UpdateListBox();
            }
        }

        private void DismissMasterClicked(object sender, EventArgs e)
        {
            int dismissMIndex = listBox1.SelectedIndex;
            if (dismissMIndex >= 0 && dismissMIndex < Factories.Length)
            {
                var factory = Factories.GetFactoryByIndex(dismissMIndex);
                if(factory.Masters > 0)
                    factory.DismissMaster();
                UpdateListBox();
            }
        }

        private void PotentialProfitClicked(object sender, EventArgs e)
        {
            int profitIndex = listBox1.SelectedIndex;
            if (profitIndex >= 0 && profitIndex < Factories.Length)
            {
                new PotentialProfitForm(Factories.GetFactoryByIndex(profitIndex)).ShowDialog();
            }
        }

        private void ExitClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void RandomAddClicked(object sender, EventArgs e)
        {
            var factory = FactoryExtension.RandomFactory();
            if(factory != null)
                Factories.AddFactory(factory);
            UpdateListBox();
        }

        private void ManualAddCLicked(object sender, EventArgs e)
        {
            var factoryForm = new NewFactoryForm();
            factoryForm.ShowDialog();
            if (factoryForm.DialogResult == DialogResult.Yes)
            {
                if(factoryForm.NewFactory != null)
                    Factories.AddFactory(factoryForm.NewFactory);
                UpdateListBox();
            }
        }
        
        private void MergeClicked(object sender, EventArgs e)
        {
            var mergeIndex = listBox1.SelectedIndices[0];
            if (mergeIndex >= 0 && mergeIndex < Factories.Length)
            {
                List<int> indices = listBox1.SelectedIndices.Cast<int>().ToList();
                Factories.MergeFactories(indices);
                UpdateListBox();
            }
        }
    }
}