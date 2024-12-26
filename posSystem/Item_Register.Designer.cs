namespace posSystem
{
    partial class Item_Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtaddcat = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtiname = new System.Windows.Forms.TextBox();
            this.btnaddcat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txticode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txticost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtiret = new System.Windows.Forms.TextBox();
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.btniadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Category";
            // 
            // txtaddcat
            // 
            this.txtaddcat.Location = new System.Drawing.Point(296, 35);
            this.txtaddcat.Name = "txtaddcat";
            this.txtaddcat.Size = new System.Drawing.Size(100, 22);
            this.txtaddcat.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(163, 160);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 16);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // txtiname
            // 
            this.txtiname.Location = new System.Drawing.Point(255, 157);
            this.txtiname.Name = "txtiname";
            this.txtiname.Size = new System.Drawing.Size(100, 22);
            this.txtiname.TabIndex = 1;
            // 
            // btnaddcat
            // 
            this.btnaddcat.Location = new System.Drawing.Point(240, 76);
            this.btnaddcat.Name = "btnaddcat";
            this.btnaddcat.Size = new System.Drawing.Size(136, 27);
            this.btnaddcat.TabIndex = 2;
            this.btnaddcat.Text = "Add Category";
            this.btnaddcat.UseVisualStyleBackColor = true;
            this.btnaddcat.Click += new System.EventHandler(this.btnaddcat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code";
            // 
            // txticode
            // 
            this.txticode.Location = new System.Drawing.Point(255, 185);
            this.txticode.Name = "txticode";
            this.txticode.Size = new System.Drawing.Size(100, 22);
            this.txticode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cost Price";
            // 
            // txticost
            // 
            this.txticost.Location = new System.Drawing.Point(255, 213);
            this.txticost.Name = "txticost";
            this.txticost.Size = new System.Drawing.Size(100, 22);
            this.txticost.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Retail Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // txtiret
            // 
            this.txtiret.Location = new System.Drawing.Point(255, 245);
            this.txtiret.Name = "txtiret";
            this.txtiret.Size = new System.Drawing.Size(100, 22);
            this.txtiret.TabIndex = 1;
            // 
            // cbcat
            // 
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Location = new System.Drawing.Point(255, 277);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(100, 24);
            this.cbcat.TabIndex = 3;
            // 
            // btniadd
            // 
            this.btniadd.Location = new System.Drawing.Point(206, 325);
            this.btniadd.Name = "btniadd";
            this.btniadd.Size = new System.Drawing.Size(132, 39);
            this.btniadd.TabIndex = 4;
            this.btniadd.Text = "Submit";
            this.btniadd.UseVisualStyleBackColor = true;
            this.btniadd.Click += new System.EventHandler(this.btniadd_Click);
            // 
            // Item_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btniadd);
            this.Controls.Add(this.cbcat);
            this.Controls.Add(this.btnaddcat);
            this.Controls.Add(this.txtiret);
            this.Controls.Add(this.txticost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txticode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtiname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtaddcat);
            this.Controls.Add(this.label1);
            this.Name = "Item_Register";
            this.Text = "Item_Register";
            this.Load += new System.EventHandler(this.Item_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddcat;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtiname;
        private System.Windows.Forms.Button btnaddcat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txticode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txticost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtiret;
        private System.Windows.Forms.ComboBox cbcat;
        private System.Windows.Forms.Button btniadd;
    }
}