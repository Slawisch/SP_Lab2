namespace SP_Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.showBt = new System.Windows.Forms.Button();
            this.factoryName = new System.Windows.Forms.TextBox();
            this.workersNum = new System.Windows.Forms.NumericUpDown();
            this.mastersNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.workersNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.mastersNum)).BeginInit();
            this.SuspendLayout();
            // 
            // showBt
            // 
            this.showBt.Location = new System.Drawing.Point(138, 132);
            this.showBt.Name = "showBt";
            this.showBt.Size = new System.Drawing.Size(75, 23);
            this.showBt.TabIndex = 0;
            this.showBt.Text = "Show me";
            this.showBt.UseCompatibleTextRendering = true;
            this.showBt.UseVisualStyleBackColor = true;
            this.showBt.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // factoryName
            // 
            this.factoryName.Location = new System.Drawing.Point(113, 23);
            this.factoryName.Name = "factoryName";
            this.factoryName.Size = new System.Drawing.Size(100, 20);
            this.factoryName.TabIndex = 1;
            // 
            // workersNum
            // 
            this.workersNum.Location = new System.Drawing.Point(113, 49);
            this.workersNum.Name = "workersNum";
            this.workersNum.Size = new System.Drawing.Size(100, 20);
            this.workersNum.TabIndex = 2;
            // 
            // mastersNum
            // 
            this.mastersNum.Location = new System.Drawing.Point(113, 75);
            this.mastersNum.Name = "mastersNum";
            this.mastersNum.Size = new System.Drawing.Size(100, 20);
            this.mastersNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Factory name:\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mastersNum);
            this.Controls.Add(this.workersNum);
            this.Controls.Add(this.factoryName);
            this.Controls.Add(this.showBt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.workersNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.mastersNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox factoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown mastersNum;
        private System.Windows.Forms.Button showBt;
        private System.Windows.Forms.NumericUpDown workersNum;

        #endregion
    }
}