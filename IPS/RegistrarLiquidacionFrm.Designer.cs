namespace IPS
{
    partial class RegistrarLiquidacionFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdentificacionTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TipoAfiliacionTxt = new System.Windows.Forms.TextBox();
            this.SalarioDevengadoTxt = new System.Windows.Forms.TextBox();
            this.NumeroDeLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.ValorDelServicioTxt = new System.Windows.Forms.TextBox();
            this.CuotaModeradoraTxt = new System.Windows.Forms.TextBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FechaDeLIquidacionDtp = new System.Windows.Forms.DateTimePicker();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NombrePacienteTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de liquidacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de liquidacion: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificacion del paciente:";
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Location = new System.Drawing.Point(309, 40);
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(126, 20);
            this.IdentificacionTxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de afiliacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salario Devengado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor del servicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cuota moderadora:";
            // 
            // TipoAfiliacionTxt
            // 
            this.TipoAfiliacionTxt.Enabled = false;
            this.TipoAfiliacionTxt.Location = new System.Drawing.Point(218, 132);
            this.TipoAfiliacionTxt.Name = "TipoAfiliacionTxt";
            this.TipoAfiliacionTxt.ReadOnly = true;
            this.TipoAfiliacionTxt.Size = new System.Drawing.Size(126, 20);
            this.TipoAfiliacionTxt.TabIndex = 8;
            // 
            // SalarioDevengadoTxt
            // 
            this.SalarioDevengadoTxt.Enabled = false;
            this.SalarioDevengadoTxt.Location = new System.Drawing.Point(218, 164);
            this.SalarioDevengadoTxt.Name = "SalarioDevengadoTxt";
            this.SalarioDevengadoTxt.ReadOnly = true;
            this.SalarioDevengadoTxt.Size = new System.Drawing.Size(126, 20);
            this.SalarioDevengadoTxt.TabIndex = 9;
            // 
            // NumeroDeLiquidacionTxt
            // 
            this.NumeroDeLiquidacionTxt.Enabled = false;
            this.NumeroDeLiquidacionTxt.Location = new System.Drawing.Point(218, 196);
            this.NumeroDeLiquidacionTxt.Name = "NumeroDeLiquidacionTxt";
            this.NumeroDeLiquidacionTxt.Size = new System.Drawing.Size(126, 20);
            this.NumeroDeLiquidacionTxt.TabIndex = 10;
            // 
            // ValorDelServicioTxt
            // 
            this.ValorDelServicioTxt.Enabled = false;
            this.ValorDelServicioTxt.Location = new System.Drawing.Point(218, 260);
            this.ValorDelServicioTxt.Name = "ValorDelServicioTxt";
            this.ValorDelServicioTxt.Size = new System.Drawing.Size(126, 20);
            this.ValorDelServicioTxt.TabIndex = 12;
            // 
            // CuotaModeradoraTxt
            // 
            this.CuotaModeradoraTxt.Enabled = false;
            this.CuotaModeradoraTxt.Location = new System.Drawing.Point(218, 292);
            this.CuotaModeradoraTxt.Name = "CuotaModeradoraTxt";
            this.CuotaModeradoraTxt.Size = new System.Drawing.Size(126, 20);
            this.CuotaModeradoraTxt.TabIndex = 13;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.BuscarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.BuscarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.BuscarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarBtn.Location = new System.Drawing.Point(460, 33);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(75, 33);
            this.BuscarBtn.TabIndex = 14;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.panel1.Location = new System.Drawing.Point(534, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 33);
            this.panel1.TabIndex = 15;
            // 
            // FechaDeLIquidacionDtp
            // 
            this.FechaDeLIquidacionDtp.Enabled = false;
            this.FechaDeLIquidacionDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDeLIquidacionDtp.Location = new System.Drawing.Point(218, 227);
            this.FechaDeLIquidacionDtp.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.FechaDeLIquidacionDtp.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.FechaDeLIquidacionDtp.Name = "FechaDeLIquidacionDtp";
            this.FechaDeLIquidacionDtp.Size = new System.Drawing.Size(126, 20);
            this.FechaDeLIquidacionDtp.TabIndex = 16;
            this.FechaDeLIquidacionDtp.Value = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Enabled = false;
            this.GuardarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.GuardarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.GuardarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.GuardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarBtn.Location = new System.Drawing.Point(137, 382);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(151, 58);
            this.GuardarBtn.TabIndex = 17;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.Enabled = false;
            this.LimpiarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.LimpiarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.LimpiarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.LimpiarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimpiarBtn.Location = new System.Drawing.Point(426, 382);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(151, 58);
            this.LimpiarBtn.TabIndex = 18;
            this.LimpiarBtn.Text = "limpiar";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.panel2.Location = new System.Drawing.Point(128, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 58);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.panel3.Location = new System.Drawing.Point(417, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 58);
            this.panel3.TabIndex = 16;
            // 
            // NombrePacienteTxt
            // 
            this.NombrePacienteTxt.Enabled = false;
            this.NombrePacienteTxt.Location = new System.Drawing.Point(218, 96);
            this.NombrePacienteTxt.Name = "NombrePacienteTxt";
            this.NombrePacienteTxt.ReadOnly = true;
            this.NombrePacienteTxt.Size = new System.Drawing.Size(126, 20);
            this.NombrePacienteTxt.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nombre del paciente:";
            // 
            // RegistrarLiquidacionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(708, 490);
            this.Controls.Add(this.NombrePacienteTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LimpiarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.FechaDeLIquidacionDtp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.CuotaModeradoraTxt);
            this.Controls.Add(this.ValorDelServicioTxt);
            this.Controls.Add(this.NumeroDeLiquidacionTxt);
            this.Controls.Add(this.SalarioDevengadoTxt);
            this.Controls.Add(this.TipoAfiliacionTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdentificacionTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarLiquidacionFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdentificacionTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TipoAfiliacionTxt;
        private System.Windows.Forms.TextBox SalarioDevengadoTxt;
        private System.Windows.Forms.TextBox NumeroDeLiquidacionTxt;
        private System.Windows.Forms.TextBox ValorDelServicioTxt;
        private System.Windows.Forms.TextBox CuotaModeradoraTxt;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker FechaDeLIquidacionDtp;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox NombrePacienteTxt;
        private System.Windows.Forms.Label label8;
    }
}