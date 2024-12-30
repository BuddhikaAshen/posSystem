namespace posSystem
{
    partial class report
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
            this.lbloutinc = new System.Windows.Forms.Label();
            this.lbloutprof = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnback = new System.Windows.Forms.Button();
            this.btnsrch = new System.Windows.Forms.Button();
            this.lblincnew = new System.Windows.Forms.Label();
            this.lblprofnew = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbloutinc
            // 
            this.lbloutinc.AutoSize = true;
            this.lbloutinc.Location = new System.Drawing.Point(35, 20);
            this.lbloutinc.Name = "lbloutinc";
            this.lbloutinc.Size = new System.Drawing.Size(44, 16);
            this.lbloutinc.TabIndex = 0;
            this.lbloutinc.Text = "label1";
            // 
            // lbloutprof
            // 
            this.lbloutprof.AutoSize = true;
            this.lbloutprof.Location = new System.Drawing.Point(35, 70);
            this.lbloutprof.Name = "lbloutprof";
            this.lbloutprof.Size = new System.Drawing.Size(44, 16);
            this.lbloutprof.TabIndex = 0;
            this.lbloutprof.Text = "label1";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(38, 118);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(697, 403);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(82, 35);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "<- Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnsrch
            // 
            this.btnsrch.Location = new System.Drawing.Point(354, 116);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(97, 30);
            this.btnsrch.TabIndex = 4;
            this.btnsrch.Text = "Search";
            this.btnsrch.UseVisualStyleBackColor = true;
            this.btnsrch.Click += new System.EventHandler(this.btnsrch_Click);
            // 
            // lblincnew
            // 
            this.lblincnew.AutoSize = true;
            this.lblincnew.Location = new System.Drawing.Point(87, 165);
            this.lblincnew.Name = "lblincnew";
            this.lblincnew.Size = new System.Drawing.Size(51, 16);
            this.lblincnew.TabIndex = 0;
            this.lblincnew.Text = "Income";
            // 
            // lblprofnew
            // 
            this.lblprofnew.AutoSize = true;
            this.lblprofnew.Location = new System.Drawing.Point(276, 165);
            this.lblprofnew.Name = "lblprofnew";
            this.lblprofnew.Size = new System.Drawing.Size(37, 16);
            this.lblprofnew.TabIndex = 0;
            this.lblprofnew.Text = "Profit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "to";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(650, 229);
            this.dataGridView1.TabIndex = 5;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsrch);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblprofnew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblincnew);
            this.Controls.Add(this.lbloutprof);
            this.Controls.Add(this.lbloutinc);
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloutinc;
        private System.Windows.Forms.Label lbloutprof;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnsrch;
        private System.Windows.Forms.Label lblincnew;
        private System.Windows.Forms.Label lblprofnew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}