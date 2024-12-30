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
            this.lblhide = new System.Windows.Forms.Label();
            this.lblout = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.Button();
            this.profit = new System.Windows.Forms.Button();
            this.sale = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(116, 152);
            this.check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(84, 50);
            this.check.TabIndex = 0;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // lblhide
            // 
            this.lblhide.AutoSize = true;
            this.lblhide.Location = new System.Drawing.Point(252, 25);
            this.lblhide.Name = "lblhide";
            this.lblhide.Size = new System.Drawing.Size(50, 20);
            this.lblhide.TabIndex = 1;
            this.lblhide.Text = "Role: ";
            this.lblhide.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblout
            // 
            this.lblout.AutoSize = true;
            this.lblout.Location = new System.Drawing.Point(339, 25);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(0, 20);
            this.lblout.TabIndex = 2;
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(116, 210);
            this.reg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(84, 50);
            this.reg.TabIndex = 0;
            this.reg.Text = "Register";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // item
            // 
            this.item.Location = new System.Drawing.Point(116, 268);
            this.item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(84, 50);
            this.item.TabIndex = 0;
            this.item.Text = "Add Items";
            this.item.UseVisualStyleBackColor = true;
            this.item.Click += new System.EventHandler(this.item_Click);
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(116, 325);
            this.stock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(84, 50);
            this.stock.TabIndex = 0;
            this.stock.Text = "Stock";
            this.stock.UseVisualStyleBackColor = true;
            this.stock.Click += new System.EventHandler(this.stock_Click);
            // 
            // profit
            // 
            this.profit.Location = new System.Drawing.Point(116, 435);
            this.profit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(84, 50);
            this.profit.TabIndex = 0;
            this.profit.Text = "Report";
            this.profit.UseVisualStyleBackColor = true;
            this.profit.Click += new System.EventHandler(this.profit_Click);
            // 
            // sale
            // 
            this.sale.Location = new System.Drawing.Point(116, 382);
            this.sale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(84, 50);
            this.sale.TabIndex = 0;
            this.sale.Text = "Sale";
            this.sale.UseVisualStyleBackColor = true;
            this.sale.Click += new System.EventHandler(this.sale_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblout);
            this.Controls.Add(this.lblhide);
            this.Controls.Add(this.sale);
            this.Controls.Add(this.profit);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.item);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.check);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label lblhide;
        private System.Windows.Forms.Label lblout;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Button item;
        private System.Windows.Forms.Button stock;
        private System.Windows.Forms.Button profit;
        private System.Windows.Forms.Button sale;
        private System.Windows.Forms.Button button1;
    }
}