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
            this.SuspendLayout();
            // 
            // lbloutinc
            // 
            this.lbloutinc.AutoSize = true;
            this.lbloutinc.Location = new System.Drawing.Point(214, 63);
            this.lbloutinc.Name = "lbloutinc";
            this.lbloutinc.Size = new System.Drawing.Size(44, 16);
            this.lbloutinc.TabIndex = 0;
            this.lbloutinc.Text = "label1";
            // 
            // lbloutprof
            // 
            this.lbloutprof.AutoSize = true;
            this.lbloutprof.Location = new System.Drawing.Point(214, 113);
            this.lbloutprof.Name = "lbloutprof";
            this.lbloutprof.Size = new System.Drawing.Size(44, 16);
            this.lbloutprof.TabIndex = 0;
            this.lbloutprof.Text = "label1";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(116, 203);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(158, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lbloutprof);
            this.Controls.Add(this.lbloutinc);
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloutinc;
        private System.Windows.Forms.Label lbloutprof;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}