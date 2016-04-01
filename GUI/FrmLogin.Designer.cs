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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogin1
            // 
            this.btnlogin1.Location = new System.Drawing.Point(231, 264);
            this.btnlogin1.Name = "btnlogin1";
            this.btnlogin1.Size = new System.Drawing.Size(136, 45);
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
            this.tbxUser1.Location = new System.Drawing.Point(211, 169);
            this.tbxUser1.Name = "tbxUser1";
            this.tbxUser1.Size = new System.Drawing.Size(180, 19);
            this.tbxUser1.TabIndex = 2;
            this.tbxUser1.Text = "Usuario";
            this.tbxUser1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxcontrasena1
            // 
            this.tbxcontrasena1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(167)))), ((int)(((byte)(118)))));
            this.tbxcontrasena1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxcontrasena1.Location = new System.Drawing.Point(211, 225);
            this.tbxcontrasena1.Name = "tbxcontrasena1";
            this.tbxcontrasena1.PasswordChar = '♠';
            this.tbxcontrasena1.Size = new System.Drawing.Size(180, 13);
            this.tbxcontrasena1.TabIndex = 3;
            this.tbxcontrasena1.Text = "Contasena";
            this.tbxcontrasena1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(39)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(483, 414);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Registro Participantes";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.free_login_form_psd;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 436);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tbxcontrasena1);
            this.Controls.Add(this.tbxUser1);
            this.Controls.Add(this.btnlogin1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogin1;
        private System.Windows.Forms.TextBox tbxUser1;
        private System.Windows.Forms.TextBox tbxcontrasena1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

