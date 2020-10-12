using System.ComponentModel;

namespace SP_Lab2
{
    partial class PotentialProfitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numExpenses = new System.Windows.Forms.NumericUpDown();
            this.numProfit = new System.Windows.Forms.NumericUpDown();
            this.numWorkers = new System.Windows.Forms.NumericUpDown();
            this.numMasters = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.numExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numMasters)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expenses:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Potential Profit:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Workers need:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Masters need;";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 22);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CancelClicked);
            // 
            // numExpenses
            // 
            this.numExpenses.Location = new System.Drawing.Point(92, 12);
            this.numExpenses.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.numExpenses.Name = "numExpenses";
            this.numExpenses.Size = new System.Drawing.Size(101, 20);
            this.numExpenses.TabIndex = 10;
            // 
            // numProfit
            // 
            this.numProfit.Location = new System.Drawing.Point(92, 56);
            this.numProfit.Maximum = new decimal(new int[] {10000000, 0, 0, 0});
            this.numProfit.Name = "numProfit";
            this.numProfit.ReadOnly = true;
            this.numProfit.Size = new System.Drawing.Size(101, 20);
            this.numProfit.TabIndex = 11;
            // 
            // numWorkers
            // 
            this.numWorkers.Location = new System.Drawing.Point(92, 82);
            this.numWorkers.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.numWorkers.Name = "numWorkers";
            this.numWorkers.ReadOnly = true;
            this.numWorkers.Size = new System.Drawing.Size(101, 20);
            this.numWorkers.TabIndex = 12;
            // 
            // numMasters
            // 
            this.numMasters.Location = new System.Drawing.Point(92, 108);
            this.numMasters.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            this.numMasters.Name = "numMasters";
            this.numMasters.ReadOnly = true;
            this.numMasters.Size = new System.Drawing.Size(101, 20);
            this.numMasters.TabIndex = 13;
            // 
            // PotentialProfitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 173);
            this.Controls.Add(this.numMasters);
            this.Controls.Add(this.numWorkers);
            this.Controls.Add(this.numProfit);
            this.Controls.Add(this.numExpenses);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PotentialProfitForm";
            this.Text = "PotentialProfitForm";
            ((System.ComponentModel.ISupportInitialize) (this.numExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numMasters)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numExpenses;
        private System.Windows.Forms.NumericUpDown numMasters;
        private System.Windows.Forms.NumericUpDown numProfit;
        private System.Windows.Forms.NumericUpDown numWorkers;

        #endregion
    }
}