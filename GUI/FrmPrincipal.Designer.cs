namespace GUI
{
    partial class FrmPrincipal
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
            this.gbxUsuario = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxVictorias = new System.Windows.Forms.TextBox();
            this.tbxTiempo = new System.Windows.Forms.TextBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnrangkin = new System.Windows.Forms.Button();
            this.tbxTiempo2 = new System.Windows.Forms.TextBox();
            this.tbxVictorias2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblUser2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxUsuario
            // 
            this.gbxUsuario.Controls.Add(this.lblNombre);
            this.gbxUsuario.Controls.Add(this.lblUsuario);
            this.gbxUsuario.Controls.Add(this.pictureBox1);
            this.gbxUsuario.Location = new System.Drawing.Point(244, 24);
            this.gbxUsuario.Name = "gbxUsuario";
            this.gbxUsuario.Size = new System.Drawing.Size(149, 69);
            this.gbxUsuario.TabIndex = 1;
            this.gbxUsuario.TabStop = false;
            this.gbxUsuario.Text = "Mi cuenta";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(18, 19);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(91, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Victorias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo Jugado:";
            // 
            // tbxVictorias
            // 
            this.tbxVictorias.Enabled = false;
            this.tbxVictorias.Location = new System.Drawing.Point(117, 31);
            this.tbxVictorias.Name = "tbxVictorias";
            this.tbxVictorias.Size = new System.Drawing.Size(100, 20);
            this.tbxVictorias.TabIndex = 4;
            // 
            // tbxTiempo
            // 
            this.tbxTiempo.Enabled = false;
            this.tbxTiempo.Location = new System.Drawing.Point(117, 73);
            this.tbxTiempo.Name = "tbxTiempo";
            this.tbxTiempo.Size = new System.Drawing.Size(100, 20);
            this.tbxTiempo.TabIndex = 5;
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(117, 109);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(87, 54);
            this.btnJugar.TabIndex = 6;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnrangkin
            // 
            this.btnrangkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrangkin.Location = new System.Drawing.Point(265, 109);
            this.btnrangkin.Name = "btnrangkin";
            this.btnrangkin.Size = new System.Drawing.Size(87, 54);
            this.btnrangkin.TabIndex = 7;
            this.btnrangkin.Text = "Rangking";
            this.btnrangkin.UseVisualStyleBackColor = true;
            this.btnrangkin.Click += new System.EventHandler(this.btnrangkin_Click);
            // 
            // tbxTiempo2
            // 
            this.tbxTiempo2.Enabled = false;
            this.tbxTiempo2.Location = new System.Drawing.Point(117, 229);
            this.tbxTiempo2.Name = "tbxTiempo2";
            this.tbxTiempo2.Size = new System.Drawing.Size(100, 20);
            this.tbxTiempo2.TabIndex = 12;
            // 
            // tbxVictorias2
            // 
            this.tbxVictorias2.Enabled = false;
            this.tbxVictorias2.Location = new System.Drawing.Point(117, 187);
            this.tbxVictorias2.Name = "tbxVictorias2";
            this.tbxVictorias2.Size = new System.Drawing.Size(100, 20);
            this.tbxVictorias2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tiempo Jugado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Victorias:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombre2);
            this.groupBox1.Controls.Add(this.lblUser2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(244, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 69);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mi cuenta";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(18, 39);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(44, 13);
            this.lblNombre2.TabIndex = 2;
            this.lblNombre2.Text = "Nombre";
            this.lblNombre2.Click += new System.EventHandler(this.lblNombre2_Click);
            // 
            // lblUser2
            // 
            this.lblUser2.AutoSize = true;
            this.lblUser2.Location = new System.Drawing.Point(18, 19);
            this.lblUser2.Name = "lblUser2";
            this.lblUser2.Size = new System.Drawing.Size(43, 13);
            this.lblUser2.TabIndex = 1;
            this.lblUser2.Text = "Usuario";
            this.lblUser2.Click += new System.EventHandler(this.lblUser2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(91, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 271);
            this.Controls.Add(this.tbxTiempo2);
            this.Controls.Add(this.tbxVictorias2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnrangkin);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.tbxTiempo);
            this.Controls.Add(this.tbxVictorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxUsuario);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.gbxUsuario.ResumeLayout(false);
            this.gbxUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxVictorias;
        private System.Windows.Forms.TextBox tbxTiempo;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnrangkin;
        private System.Windows.Forms.TextBox tbxTiempo2;
        private System.Windows.Forms.TextBox tbxVictorias2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblUser2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}