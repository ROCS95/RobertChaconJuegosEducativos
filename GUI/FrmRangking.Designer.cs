namespace GUI
{
    partial class FrmRangking
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
            this.dgvRangking = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCorreo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRangking
            // 
            this.dgvRangking.AllowUserToAddRows = false;
            this.dgvRangking.AllowUserToDeleteRows = false;
            this.dgvRangking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRangking.Location = new System.Drawing.Point(22, 24);
            this.dgvRangking.Name = "dgvRangking";
            this.dgvRangking.ReadOnly = true;
            this.dgvRangking.Size = new System.Drawing.Size(344, 150);
            this.dgvRangking.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(22, 197);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 78);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCorreo
            // 
            this.btnCorreo.Location = new System.Drawing.Point(216, 197);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(150, 78);
            this.btnCorreo.TabIndex = 2;
            this.btnCorreo.Text = "Enviar por Correo";
            this.btnCorreo.UseVisualStyleBackColor = true;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // FrmRangking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 287);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvRangking);
            this.Name = "FrmRangking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRangking";
            this.Load += new System.EventHandler(this.FrmRangking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRangking;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCorreo;
    }
}