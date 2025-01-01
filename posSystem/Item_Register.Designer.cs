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
            this.label2 = new System.Windows.Forms.Label();
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.btniadd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbsup = new System.Windows.Forms.ComboBox();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Category";
            // 
            // txtaddcat
            // 
            this.txtaddcat.Location = new System.Drawing.Point(142, 175);
            this.txtaddcat.Name = "txtaddcat";
            this.txtaddcat.Size = new System.Drawing.Size(100, 22);
            this.txtaddcat.TabIndex = 6;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(427, 134);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 16);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // txtiname
            // 
            this.txtiname.Location = new System.Drawing.Point(519, 131);
            this.txtiname.Name = "txtiname";
            this.txtiname.Size = new System.Drawing.Size(100, 22);
            this.txtiname.TabIndex = 0;
            // 
            // btnaddcat
            // 
            this.btnaddcat.Location = new System.Drawing.Point(86, 216);
            this.btnaddcat.Name = "btnaddcat";
            this.btnaddcat.Size = new System.Drawing.Size(136, 27);
            this.btnaddcat.TabIndex = 7;
            this.btnaddcat.Text = "Add Category";
            this.btnaddcat.UseVisualStyleBackColor = true;
            this.btnaddcat.Click += new System.EventHandler(this.btnaddcat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code";
            // 
            // txticode
            // 
            this.txticode.Location = new System.Drawing.Point(519, 159);
            this.txticode.Name = "txticode";
            this.txticode.Size = new System.Drawing.Size(100, 22);
            this.txticode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // cbcat
            // 
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Location = new System.Drawing.Point(519, 192);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(100, 24);
            this.cbcat.TabIndex = 4;
            // 
            // btniadd
            // 
            this.btniadd.Location = new System.Drawing.Point(461, 275);
            this.btniadd.Name = "btniadd";
            this.btniadd.Size = new System.Drawing.Size(132, 39);
            this.btniadd.TabIndex = 5;
            this.btniadd.Text = "Submit";
            this.btniadd.UseVisualStyleBackColor = true;
            this.btniadd.Click += new System.EventHandler(this.btniadd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "Add Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(423, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 39);
            this.label7.TabIndex = 7;
            this.label7.Text = "Add Items";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Supplier";
            // 
            // cbsup
            // 
            this.cbsup.FormattingEnabled = true;
            this.cbsup.Location = new System.Drawing.Point(519, 224);
            this.cbsup.Name = "cbsup";
            this.cbsup.Size = new System.Drawing.Size(100, 24);
            this.cbsup.TabIndex = 4;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(667, 409);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(94, 29);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "<- Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Item_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btniadd);
            this.Controls.Add(this.cbsup);
            this.Controls.Add(this.cbcat);
            this.Controls.Add(this.btnaddcat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txticode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtiname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtaddcat);
            this.Controls.Add(this.label1);
            this.Name = "Item_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbcat;
        private System.Windows.Forms.Button btniadd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbsup;
        private System.Windows.Forms.Button btnback;
    }
}