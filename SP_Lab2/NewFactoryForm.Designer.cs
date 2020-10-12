using System.ComponentModel;

namespace SP_Lab2
{
    partial class NewFactoryForm
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numWSalary = new System.Windows.Forms.NumericUpDown();
            this.numMSalary = new System.Windows.Forms.NumericUpDown();
            this.numWProfit = new System.Windows.Forms.NumericUpDown();
            this.numMProfit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.numWSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numMSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numWProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numMProfit)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(114, 141);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 23;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.CancelClicked);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(8, 141);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 22;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.AddClicked);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(89, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Master profit:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Worker profit:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Master salary:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Worker salary:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numWSalary
            // 
            this.numWSalary.Location = new System.Drawing.Point(89, 30);
            this.numWSalary.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.numWSalary.Name = "numWSalary";
            this.numWSalary.Size = new System.Drawing.Size(100, 20);
            this.numWSalary.TabIndex = 24;
            // 
            // numMSalary
            // 
            this.numMSalary.Location = new System.Drawing.Point(89, 56);
            this.numMSalary.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.numMSalary.Name = "numMSalary";
            this.numMSalary.Size = new System.Drawing.Size(100, 20);
            this.numMSalary.TabIndex = 25;
            // 
            // numWProfit
            // 
            this.numWProfit.Location = new System.Drawing.Point(89, 82);
            this.numWProfit.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.numWProfit.Name = "numWProfit";
            this.numWProfit.Size = new System.Drawing.Size(100, 20);
            this.numWProfit.TabIndex = 26;
            // 
            // numMProfit
            // 
            this.numMProfit.Location = new System.Drawing.Point(89, 108);
            this.numMProfit.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.numMProfit.Name = "numMProfit";
            this.numMProfit.Size = new System.Drawing.Size(100, 20);
            this.numMProfit.TabIndex = 27;
            // 
            // NewFactoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 171);
            this.Controls.Add(this.numMProfit);
            this.Controls.Add(this.numWProfit);
            this.Controls.Add(this.numMSalary);
            this.Controls.Add(this.numWSalary);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewFactoryForm";
            this.Text = "NewFactoryForm";
            ((System.ComponentModel.ISupportInitialize) (this.numWSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numMSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numWProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numMProfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMProfit;
        private System.Windows.Forms.NumericUpDown numMSalary;
        private System.Windows.Forms.NumericUpDown numWProfit;
        private System.Windows.Forms.NumericUpDown numWSalary;
        private System.Windows.Forms.TextBox tbName;

        #endregion
    }
}