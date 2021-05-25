
namespace HES
{
    partial class inicioUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicioUsuario));
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMU = new System.Windows.Forms.Button();
            this.btnRC = new System.Windows.Forms.Button();
            this.btnCC = new System.Windows.Forms.Button();
            this.btnCS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMin
            // 
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(698, 24);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(37, 17);
            this.btnMin.TabIndex = 11;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(741, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 29);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 500);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 174);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMU
            // 
            this.btnMU.BackColor = System.Drawing.Color.White;
            this.btnMU.FlatAppearance.BorderSize = 0;
            this.btnMU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMU.ForeColor = System.Drawing.Color.Black;
            this.btnMU.Location = new System.Drawing.Point(307, 286);
            this.btnMU.Name = "btnMU";
            this.btnMU.Size = new System.Drawing.Size(408, 40);
            this.btnMU.TabIndex = 13;
            this.btnMU.Text = "Mi Usuario";
            this.btnMU.UseVisualStyleBackColor = false;
            // 
            // btnRC
            // 
            this.btnRC.BackColor = System.Drawing.Color.White;
            this.btnRC.FlatAppearance.BorderSize = 0;
            this.btnRC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRC.ForeColor = System.Drawing.Color.Black;
            this.btnRC.Location = new System.Drawing.Point(307, 332);
            this.btnRC.Name = "btnRC";
            this.btnRC.Size = new System.Drawing.Size(408, 40);
            this.btnRC.TabIndex = 14;
            this.btnRC.Text = "Registrar Cita";
            this.btnRC.UseVisualStyleBackColor = false;
            // 
            // btnCC
            // 
            this.btnCC.BackColor = System.Drawing.Color.White;
            this.btnCC.FlatAppearance.BorderSize = 0;
            this.btnCC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCC.ForeColor = System.Drawing.Color.Black;
            this.btnCC.Location = new System.Drawing.Point(307, 378);
            this.btnCC.Name = "btnCC";
            this.btnCC.Size = new System.Drawing.Size(408, 40);
            this.btnCC.TabIndex = 15;
            this.btnCC.Text = "Consultar Cita";
            this.btnCC.UseVisualStyleBackColor = false;
            // 
            // btnCS
            // 
            this.btnCS.BackColor = System.Drawing.Color.White;
            this.btnCS.FlatAppearance.BorderSize = 0;
            this.btnCS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCS.ForeColor = System.Drawing.Color.Black;
            this.btnCS.Location = new System.Drawing.Point(307, 424);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(408, 40);
            this.btnCS.TabIndex = 16;
            this.btnCS.Text = "Cerrar Sesiòn";
            this.btnCS.UseVisualStyleBackColor = false;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // inicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.btnCS);
            this.Controls.Add(this.btnCC);
            this.Controls.Add(this.btnRC);
            this.Controls.Add(this.btnMU);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inicioUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.inicioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMU;
        private System.Windows.Forms.Button btnRC;
        private System.Windows.Forms.Button btnCC;
        private System.Windows.Forms.Button btnCS;
    }
}