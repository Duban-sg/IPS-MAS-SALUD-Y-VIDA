namespace IPS
{
    partial class RegistrarPersonaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPersonaFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TipoAliacionCbm = new System.Windows.Forms.ComboBox();
            this.IdentificacionTxt = new System.Windows.Forms.TextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.PrimerApellidoTxt = new System.Windows.Forms.TextBox();
            this.SegundoApellidoTxt = new System.Windows.Forms.TextBox();
            this.SalarioDevengadoTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(98, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(127, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(69, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo apellido: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(85, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer apellido: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(92, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo afiliacion: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(60, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salario devengado: ";
            // 
            // TipoAliacionCbm
            // 
            this.TipoAliacionCbm.FormattingEnabled = true;
            this.TipoAliacionCbm.Items.AddRange(new object[] {
            "SUBSIDIADO",
            "CONTRIBUTIVO"});
            this.TipoAliacionCbm.Location = new System.Drawing.Point(196, 253);
            this.TipoAliacionCbm.Name = "TipoAliacionCbm";
            this.TipoAliacionCbm.Size = new System.Drawing.Size(134, 21);
            this.TipoAliacionCbm.TabIndex = 6;
            this.TipoAliacionCbm.Text = "SUBSIDIADO";
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Location = new System.Drawing.Point(196, 93);
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(134, 20);
            this.IdentificacionTxt.TabIndex = 7;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(196, 133);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(134, 20);
            this.NombreTxt.TabIndex = 8;
            // 
            // PrimerApellidoTxt
            // 
            this.PrimerApellidoTxt.Location = new System.Drawing.Point(196, 173);
            this.PrimerApellidoTxt.Name = "PrimerApellidoTxt";
            this.PrimerApellidoTxt.Size = new System.Drawing.Size(134, 20);
            this.PrimerApellidoTxt.TabIndex = 9;
            // 
            // SegundoApellidoTxt
            // 
            this.SegundoApellidoTxt.Location = new System.Drawing.Point(196, 213);
            this.SegundoApellidoTxt.Name = "SegundoApellidoTxt";
            this.SegundoApellidoTxt.Size = new System.Drawing.Size(134, 20);
            this.SegundoApellidoTxt.TabIndex = 10;
            this.SegundoApellidoTxt.TextChanged += new System.EventHandler(this.SegundoApellidoTxt_TextChanged);
            // 
            // SalarioDevengadoTxt
            // 
            this.SalarioDevengadoTxt.Location = new System.Drawing.Point(196, 293);
            this.SalarioDevengadoTxt.Name = "SalarioDevengadoTxt";
            this.SalarioDevengadoTxt.Size = new System.Drawing.Size(134, 20);
            this.SalarioDevengadoTxt.TabIndex = 11;
            this.SalarioDevengadoTxt.Text = "0";
            this.SalarioDevengadoTxt.TextChanged += new System.EventHandler(this.SalarioDevengadoTxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.FlatAppearance.BorderSize = 0;
            this.GuardarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.GuardarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.GuardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarBtn.Location = new System.Drawing.Point(130, 392);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(151, 58);
            this.GuardarBtn.TabIndex = 13;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LimpiarBtn.FlatAppearance.BorderSize = 0;
            this.LimpiarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.LimpiarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.LimpiarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimpiarBtn.Location = new System.Drawing.Point(442, 392);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(151, 58);
            this.LimpiarBtn.TabIndex = 14;
            this.LimpiarBtn.Text = "LImpiar campos";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.panel1.Location = new System.Drawing.Point(432, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 58);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.panel2.Location = new System.Drawing.Point(121, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 58);
            this.panel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "*";
            // 
            // RegistrarPersonaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(708, 490);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LimpiarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SalarioDevengadoTxt);
            this.Controls.Add(this.SegundoApellidoTxt);
            this.Controls.Add(this.PrimerApellidoTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.IdentificacionTxt);
            this.Controls.Add(this.TipoAliacionCbm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarPersonaFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegistrarPersonaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TipoAliacionCbm;
        private System.Windows.Forms.TextBox IdentificacionTxt;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox PrimerApellidoTxt;
        private System.Windows.Forms.TextBox SegundoApellidoTxt;
        private System.Windows.Forms.TextBox SalarioDevengadoTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}