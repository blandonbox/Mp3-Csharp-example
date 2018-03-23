namespace Mp3Example
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
            this.FilePathtxt = new System.Windows.Forms.TextBox();
            this.Browsebtn = new System.Windows.Forms.Button();
            this.Stopbtn = new System.Windows.Forms.Button();
            this.Playbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FilePathtxt
            // 
            this.FilePathtxt.Location = new System.Drawing.Point(79, 63);
            this.FilePathtxt.Name = "FilePathtxt";
            this.FilePathtxt.ReadOnly = true;
            this.FilePathtxt.Size = new System.Drawing.Size(344, 20);
            this.FilePathtxt.TabIndex = 1;
            // 
            // Browsebtn
            // 
            this.Browsebtn.Location = new System.Drawing.Point(211, 12);
            this.Browsebtn.Name = "Browsebtn";
            this.Browsebtn.Size = new System.Drawing.Size(75, 23);
            this.Browsebtn.TabIndex = 2;
            this.Browsebtn.Text = "Browse";
            this.Browsebtn.UseVisualStyleBackColor = true;
            this.Browsebtn.Click += new System.EventHandler(this.Browsebtn_Click);
            // 
            // Stopbtn
            // 
            this.Stopbtn.Image = global::Mp3Example.Properties.Resources.stop_playing_16x16;
            this.Stopbtn.Location = new System.Drawing.Point(331, 7);
            this.Stopbtn.Name = "Stopbtn";
            this.Stopbtn.Size = new System.Drawing.Size(33, 33);
            this.Stopbtn.TabIndex = 4;
            this.Stopbtn.UseVisualStyleBackColor = true;
            this.Stopbtn.Click += new System.EventHandler(this.Stopbtn_Click);
            // 
            // Playbtn
            // 
            this.Playbtn.Image = global::Mp3Example.Properties.Resources.play_16x16;
            this.Playbtn.Location = new System.Drawing.Point(292, 7);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.Size = new System.Drawing.Size(33, 33);
            this.Playbtn.TabIndex = 3;
            this.Playbtn.UseVisualStyleBackColor = true;
            this.Playbtn.Click += new System.EventHandler(this.Playbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mp3 player example.\r\n\r\nBrowse a .mp3 file and click play or stop. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current file:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 98);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stopbtn);
            this.Controls.Add(this.Playbtn);
            this.Controls.Add(this.Browsebtn);
            this.Controls.Add(this.FilePathtxt);
            this.Name = "Form1";
            this.Text = "Mp3 example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FilePathtxt;
        private System.Windows.Forms.Button Browsebtn;
        private System.Windows.Forms.Button Playbtn;
        private System.Windows.Forms.Button Stopbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

