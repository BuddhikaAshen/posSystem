namespace posSystem
{
    partial class dashboard
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
            this.check = new System.Windows.Forms.Button();
            this.lblout = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.Button();
            this.profit = new System.Windows.Forms.Button();
            this.sale = new System.Windows.Forms.Button();
            this.btlout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(621, 397);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 40);
            this.check.TabIndex = 1;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // lblout
            // 
            this.lblout.AutoSize = true;
            this.lblout.Location = new System.Drawing.Point(648, 20);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(0, 16);
            this.lblout.TabIndex = 2;
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(70, 273);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(75, 56);
            this.reg.TabIndex = 1;
            this.reg.Text = "Cashier Register";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // item
            // 
            this.item.Location = new System.Drawing.Point(370, 147);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(75, 40);
            this.item.TabIndex = 0;
            this.item.Text = "Add Items";
            this.item.UseVisualStyleBackColor = true;
            this.item.Click += new System.EventHandler(this.item_Click);
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(470, 147);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(75, 40);
            this.stock.TabIndex = 0;
            this.stock.Text = "Stock";
            this.stock.UseVisualStyleBackColor = true;
            this.stock.Click += new System.EventHandler(this.stock_Click);
            // 
            // profit
            // 
            this.profit.Location = new System.Drawing.Point(70, 335);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(75, 40);
            this.profit.TabIndex = 1;
            this.profit.Text = "Report";
            this.profit.UseVisualStyleBackColor = true;
            this.profit.Click += new System.EventHandler(this.profit_Click);
            // 
            // sale
            // 
            this.sale.Location = new System.Drawing.Point(277, 147);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(75, 40);
            this.sale.TabIndex = 0;
            this.sale.Text = "Sale";
            this.sale.UseVisualStyleBackColor = true;
            this.sale.Click += new System.EventHandler(this.sale_Click);
            // 
            // btlout
            // 
            this.btlout.Location = new System.Drawing.Point(713, 397);
            this.btlout.Name = "btlout";
            this.btlout.Size = new System.Drawing.Size(75, 39);
            this.btlout.TabIndex = 3;
            this.btlout.Text = "Logout";
            this.btlout.UseVisualStyleBackColor = true;
            this.btlout.Click += new System.EventHandler(this.btlout_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btlout);
            this.Controls.Add(this.lblout);
            this.Controls.Add(this.sale);
            this.Controls.Add(this.profit);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.item);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.check);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label lblout;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Button item;
        private System.Windows.Forms.Button stock;
        private System.Windows.Forms.Button profit;
        private System.Windows.Forms.Button sale;
        private System.Windows.Forms.Button btlout;
    }
}