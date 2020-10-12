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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dismissToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.potentialProfitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(897, 225);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.LbDoubleClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addToolStripMenuItem, this.deleteToolStripMenuItem, this.hireToolStripMenuItem, this.dismissToolStripMenuItem, this.potentialProfitToolStripMenuItem, this.mergeToolStripMenuItem, this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.randomToolStripMenuItem, this.manualToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.randomToolStripMenuItem.Text = "Random";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.RandomAddClicked);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.ManualAddCLicked);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteClicked);
            // 
            // hireToolStripMenuItem
            // 
            this.hireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.workerToolStripMenuItem, this.masterToolStripMenuItem});
            this.hireToolStripMenuItem.Name = "hireToolStripMenuItem";
            this.hireToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.hireToolStripMenuItem.Text = "Hire";
            // 
            // workerToolStripMenuItem
            // 
            this.workerToolStripMenuItem.Name = "workerToolStripMenuItem";
            this.workerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.workerToolStripMenuItem.Text = "Worker";
            this.workerToolStripMenuItem.Click += new System.EventHandler(this.HireWorkerClicked);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.masterToolStripMenuItem.Text = "Master";
            this.masterToolStripMenuItem.Click += new System.EventHandler(this.HireMasterClicked);
            // 
            // dismissToolStripMenuItem
            // 
            this.dismissToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.workerToolStripMenuItem1, this.masterToolStripMenuItem1});
            this.dismissToolStripMenuItem.Name = "dismissToolStripMenuItem";
            this.dismissToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.dismissToolStripMenuItem.Text = "Dismiss";
            // 
            // workerToolStripMenuItem1
            // 
            this.workerToolStripMenuItem1.Name = "workerToolStripMenuItem1";
            this.workerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.workerToolStripMenuItem1.Text = "Worker";
            this.workerToolStripMenuItem1.Click += new System.EventHandler(this.DismissWorkerClicked);
            // 
            // masterToolStripMenuItem1
            // 
            this.masterToolStripMenuItem1.Name = "masterToolStripMenuItem1";
            this.masterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.masterToolStripMenuItem1.Text = "Master";
            this.masterToolStripMenuItem1.Click += new System.EventHandler(this.DismissMasterClicked);
            // 
            // potentialProfitToolStripMenuItem
            // 
            this.potentialProfitToolStripMenuItem.Name = "potentialProfitToolStripMenuItem";
            this.potentialProfitToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.potentialProfitToolStripMenuItem.Text = "Potential Profit";
            this.potentialProfitToolStripMenuItem.Click += new System.EventHandler(this.PotentialProfitClicked);
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mergeToolStripMenuItem.Text = "Merge";
            this.mergeToolStripMenuItem.Click += new System.EventHandler(this.MergeClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 249);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dismissToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potentialProfitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workerToolStripMenuItem1;

        #endregion
    }
}