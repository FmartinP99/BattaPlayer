namespace WindowsFormsApp1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPlaylistName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlaylistNameOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 28);
            this.panel1.TabIndex = 0;
            // 
            // textBoxPlaylistName
            // 
            this.textBoxPlaylistName.Location = new System.Drawing.Point(12, 47);
            this.textBoxPlaylistName.Name = "textBoxPlaylistName";
            this.textBoxPlaylistName.Size = new System.Drawing.Size(224, 20);
            this.textBoxPlaylistName.TabIndex = 1;
            this.textBoxPlaylistName.TextChanged += new System.EventHandler(this.textBoxPlaylistName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the playlist\'s new name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonPlaylistNameOK
            // 
            this.buttonPlaylistNameOK.Location = new System.Drawing.Point(87, 75);
            this.buttonPlaylistNameOK.Name = "buttonPlaylistNameOK";
            this.buttonPlaylistNameOK.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaylistNameOK.TabIndex = 3;
            this.buttonPlaylistNameOK.Text = "OK";
            this.buttonPlaylistNameOK.UseVisualStyleBackColor = true;
            this.buttonPlaylistNameOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 110);
            this.Controls.Add(this.buttonPlaylistNameOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlaylistName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPlaylistName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlaylistNameOK;
    }
}