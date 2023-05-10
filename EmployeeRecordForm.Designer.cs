namespace Employee_Class
{
    partial class EmployeeRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRecordForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lBoxEmployeeInfo = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Employee_Class.Properties.Resources.woman;
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lBoxEmployeeInfo
            // 
            this.lBoxEmployeeInfo.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxEmployeeInfo.FormattingEnabled = true;
            this.lBoxEmployeeInfo.ItemHeight = 29;
            this.lBoxEmployeeInfo.Location = new System.Drawing.Point(377, 50);
            this.lBoxEmployeeInfo.Name = "lBoxEmployeeInfo";
            this.lBoxEmployeeInfo.Size = new System.Drawing.Size(411, 352);
            this.lBoxEmployeeInfo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arsenal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(776, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "©2023 Michelle Alzola | www.michellealzoladesign.com";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lBoxEmployeeInfo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeRecordForm";
            this.Text = "Employee Record Summary";
            this.Load += new System.EventHandler(this.EmployeeRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListBox lBoxEmployeeInfo;
        private System.Windows.Forms.Label label5;
    }
}