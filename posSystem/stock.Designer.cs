namespace posSystem
{
    partial class stock
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
            this.txtscode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtscost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsret = new System.Windows.Forms.TextBox();
            this.btnsadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsqtty = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtqtty = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txticodesrch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // txtscode
            // 
            this.txtscode.Location = new System.Drawing.Point(133, 113);
            this.txtscode.Name = "txtscode";
            this.txtscode.Size = new System.Drawing.Size(161, 22);
            this.txtscode.TabIndex = 0;
            this.txtscode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtscode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "cost";
            // 
            // txtscost
            // 
            this.txtscost.Location = new System.Drawing.Point(133, 214);
            this.txtscost.Name = "txtscost";
            this.txtscost.Size = new System.Drawing.Size(161, 22);
            this.txtscost.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Retail";
            // 
            // txtsret
            // 
            this.txtsret.Location = new System.Drawing.Point(133, 242);
            this.txtsret.Name = "txtsret";
            this.txtsret.Size = new System.Drawing.Size(161, 22);
            this.txtsret.TabIndex = 2;
            // 
            // btnsadd
            // 
            this.btnsadd.Location = new System.Drawing.Point(101, 317);
            this.btnsadd.Name = "btnsadd";
            this.btnsadd.Size = new System.Drawing.Size(152, 41);
            this.btnsadd.TabIndex = 4;
            this.btnsadd.Text = "submit";
            this.btnsadd.UseVisualStyleBackColor = true;
            this.btnsadd.Click += new System.EventHandler(this.btnsadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // txtsqtty
            // 
            this.txtsqtty.Location = new System.Drawing.Point(133, 270);
            this.txtsqtty.Name = "txtsqtty";
            this.txtsqtty.Size = new System.Drawing.Size(161, 22);
            this.txtsqtty.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 1;
            // 
            // txtqtty
            // 
            this.txtqtty.Location = new System.Drawing.Point(133, 270);
            this.txtqtty.Name = "txtqtty";
            this.txtqtty.Size = new System.Drawing.Size(161, 22);
            this.txtqtty.TabIndex = 3;
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(133, 151);
            this.txtsname.Name = "txtsname";
            this.txtsname.ReadOnly = true;
            this.txtsname.Size = new System.Drawing.Size(161, 22);
            this.txtsname.TabIndex = 8;
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(133, 186);
            this.txtsid.Name = "txtsid";
            this.txtsid.ReadOnly = true;
            this.txtsid.Size = new System.Drawing.Size(161, 22);
            this.txtsid.TabIndex = 8;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(799, 412);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(86, 26);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "<- Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Add Stock";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(569, 338);
            this.dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txticodesrch
            // 
            this.txticodesrch.Location = new System.Drawing.Point(475, 28);
            this.txticodesrch.Name = "txticodesrch";
            this.txticodesrch.Size = new System.Drawing.Size(161, 22);
            this.txticodesrch.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item Code";
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsadd);
            this.Controls.Add(this.txtsid);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.txticodesrch);
            this.Controls.Add(this.txtqtty);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtsqtty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtscost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtscode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stock";
            this.Load += new System.EventHandler(this.stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtscode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtscost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsret;
        private System.Windows.Forms.Button btnsadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsqtty;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtqtty;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txticodesrch;
        private System.Windows.Forms.Label label6;
    }
}