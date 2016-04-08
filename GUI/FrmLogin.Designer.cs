namespace GUI
{
    partial class FrmLogin
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
            this.btnlogin1 = new System.Windows.Forms.Button();
            this.tbxUser1 = new System.Windows.Forms.TextBox();
            this.tbxcontrasena1 = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tbxcontrasena2 = new System.Windows.Forms.TextBox();
            this.tbxUser2 = new System.Windows.Forms.TextBox();
            this.btnlogin2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogin1
            // 
            this.btnlogin1.Location = new System.Drawing.Point(170, 263);
            this.btnlogin1.Name = "btnlogin1";
            this.btnlogin1.Size = new System.Drawing.Size(118, 45);
            this.btnlogin1.TabIndex = 1;
            this.btnlogin1.Text = "Login";
            this.btnlogin1.UseVisualStyleBackColor = true;
            this.btnlogin1.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // tbxUser1
            // 
            this.tbxUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(167)))), ((int)(((byte)(118)))));
            this.tbxUser1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxUser1.Location = new System.Drawing.Point(150, 173);
            this.tbxUser1.Name = "tbxUser1";
            this.tbxUser1.Size = new System.Drawing.Size(151, 19);
            this.tbxUser1.TabIndex = 2;
            this.tbxUser1.Text = "1";
            this.tbxUser1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxcontrasena1
            // 
            this.tbxcontrasena1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(167)))), ((int)(((byte)(118)))));
            this.tbxcontrasena1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxcontrasena1.Location = new System.Drawing.Point(151, 227);
            this.tbxcontrasena1.Name = "tbxcontrasena1";
            this.tbxcontrasena1.PasswordChar = '♠';
            this.tbxcontrasena1.Size = new System.Drawing.Size(151, 13);
            this.tbxcontrasena1.TabIndex = 3;
            this.tbxcontrasena1.Text = "123";
            this.tbxcontrasena1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(39)))));
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(401, 404);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(110, 13);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Registro Participantes";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // tbxcontrasena2
            // 
            this.tbxcontrasena2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(167)))), ((int)(((byte)(118)))));
            this.tbxcontrasena2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxcontrasena2.Location = new System.Drawing.Point(602, 226);
            this.tbxcontrasena2.Name = "tbxcontrasena2";
            this.tbxcontrasena2.PasswordChar = '♠';
            this.tbxcontrasena2.Size = new System.Drawing.Size(151, 13);
            this.tbxcontrasena2.TabIndex = 10;
            this.tbxcontrasena2.Text = "123";
            this.tbxcontrasena2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUser2
            // 
            this.tbxUser2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(167)))), ((int)(((byte)(118)))));
            this.tbxUser2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxUser2.Location = new System.Drawing.Point(602, 173);
            this.tbxUser2.Name = "tbxUser2";
            this.tbxUser2.Size = new System.Drawing.Size(151, 19);
            this.tbxUser2.TabIndex = 9;
            this.tbxUser2.Text = "2";
            this.tbxUser2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnlogin2
            // 
            this.btnlogin2.Location = new System.Drawing.Point(617, 263);
            this.btnlogin2.Name = "btnlogin2";
            this.btnlogin2.Size = new System.Drawing.Size(118, 45);
            this.btnlogin2.TabIndex = 8;
            this.btnlogin2.Text = "Login";
            this.btnlogin2.UseVisualStyleBackColor = true;
            this.btnlogin2.Click += new System.EventHandler(this.btnlogin2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.free_login_form_psd;
            this.pictureBox2.Location = new System.Drawing.Point(451, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(455, 436);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.free_login_form_psd;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 436);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.tbxcontrasena2);
            this.Controls.Add(this.tbxUser2);
            this.Controls.Add(this.btnlogin2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbxcontrasena1);
            this.Controls.Add(this.tbxUser1);
            this.Controls.Add(this.btnlogin1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnlogin1;
        private System.Windows.Forms.TextBox tbxUser1;
        private System.Windows.Forms.TextBox tbxcontrasena1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox tbxcontrasena2;
        private System.Windows.Forms.TextBox tbxUser2;
        private System.Windows.Forms.Button btnlogin2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

