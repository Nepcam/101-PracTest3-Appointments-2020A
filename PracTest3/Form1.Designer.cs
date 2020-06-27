namespace PracTest3
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
            this.pictureBoxCalendar = new System.Windows.Forms.PictureBox();
            this.listBoxCalendar = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCalendar
            // 
            this.pictureBoxCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCalendar.Location = new System.Drawing.Point(11, 49);
            this.pictureBoxCalendar.Name = "pictureBoxCalendar";
            this.pictureBoxCalendar.Size = new System.Drawing.Size(500, 600);
            this.pictureBoxCalendar.TabIndex = 0;
            this.pictureBoxCalendar.TabStop = false;
            // 
            // listBoxCalendar
            // 
            this.listBoxCalendar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCalendar.FormattingEnabled = true;
            this.listBoxCalendar.ItemHeight = 16;
            this.listBoxCalendar.Location = new System.Drawing.Point(517, 49);
            this.listBoxCalendar.Name = "listBoxCalendar";
            this.listBoxCalendar.Size = new System.Drawing.Size(336, 596);
            this.listBoxCalendar.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 723);
            this.Controls.Add(this.listBoxCalendar);
            this.Controls.Add(this.pictureBoxCalendar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "101 Practical Test 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCalendar;
        private System.Windows.Forms.ListBox listBoxCalendar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

