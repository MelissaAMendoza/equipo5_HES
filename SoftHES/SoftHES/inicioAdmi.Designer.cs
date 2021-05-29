
namespace SoftHES
{
    partial class inicioAdmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicioAdmi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMant = new System.Windows.Forms.Button();
            this.btnCS = new System.Windows.Forms.Button();
            this.btnGR = new System.Windows.Forms.Button();
            this.btnAdmMed = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblAdmi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 640);
            this.panel1.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 240);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(976, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 22);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 60;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMin
            // 
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(948, 3);
            this.btnMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 22);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 59;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMant
            // 
            this.btnMant.BackColor = System.Drawing.Color.Transparent;
            this.btnMant.FlatAppearance.BorderSize = 0;
            this.btnMant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMant.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnMant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMant.Location = new System.Drawing.Point(417, 357);
            this.btnMant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMant.Name = "btnMant";
            this.btnMant.Size = new System.Drawing.Size(408, 50);
            this.btnMant.TabIndex = 69;
            this.btnMant.Text = "Mantenimiento";
            this.btnMant.UseVisualStyleBackColor = false;
            this.btnMant.Click += new System.EventHandler(this.btnMant_Click);
            // 
            // btnCS
            // 
            this.btnCS.BackColor = System.Drawing.Color.Transparent;
            this.btnCS.FlatAppearance.BorderSize = 0;
            this.btnCS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCS.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnCS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCS.Location = new System.Drawing.Point(417, 509);
            this.btnCS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(408, 50);
            this.btnCS.TabIndex = 68;
            this.btnCS.Text = "Cerrar Sesión";
            this.btnCS.UseVisualStyleBackColor = false;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // btnGR
            // 
            this.btnGR.BackColor = System.Drawing.Color.Transparent;
            this.btnGR.FlatAppearance.BorderSize = 0;
            this.btnGR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGR.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnGR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGR.Location = new System.Drawing.Point(417, 434);
            this.btnGR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGR.Name = "btnGR";
            this.btnGR.Size = new System.Drawing.Size(408, 50);
            this.btnGR.TabIndex = 67;
            this.btnGR.Text = "Generación de Reportes";
            this.btnGR.UseVisualStyleBackColor = false;
            this.btnGR.Click += new System.EventHandler(this.btnGR_Click);
            // 
            // btnAdmMed
            // 
            this.btnAdmMed.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmMed.FlatAppearance.BorderSize = 0;
            this.btnAdmMed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdmMed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdmMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmMed.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnAdmMed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdmMed.Location = new System.Drawing.Point(417, 279);
            this.btnAdmMed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdmMed.Name = "btnAdmMed";
            this.btnAdmMed.Size = new System.Drawing.Size(408, 50);
            this.btnAdmMed.TabIndex = 66;
            this.btnAdmMed.Text = "Administrar Médico";
            this.btnAdmMed.UseVisualStyleBackColor = false;
            this.btnAdmMed.Click += new System.EventHandler(this.btnAdmMed_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(305, 26);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 17);
            this.lblMensaje.TabIndex = 70;
            // 
            // lblAdmi
            // 
            this.lblAdmi.AutoSize = true;
            this.lblAdmi.Location = new System.Drawing.Point(269, 69);
            this.lblAdmi.Name = "lblAdmi";
            this.lblAdmi.Size = new System.Drawing.Size(95, 17);
            this.lblAdmi.TabIndex = 71;
            this.lblAdmi.Text = "Administrador";
            // 
            // inicioAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.lblAdmi);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMant);
            this.Controls.Add(this.btnCS);
            this.Controls.Add(this.btnGR);
            this.Controls.Add(this.btnAdmMed);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inicioAdmi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "inicioAdmi";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.Button btnMant;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btnGR;
        private System.Windows.Forms.Button btnAdmMed;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblAdmi;
    }
}