namespace IPS
{
    partial class ConsultarLiquidacionFrm
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
            this.FiltroCbm = new System.Windows.Forms.ComboBox();
            this.FiltroLbl = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.FechaDtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TodosTxt = new System.Windows.Forms.TextBox();
            this.CantidadContributivoTxt = new System.Windows.Forms.TextBox();
            this.CAntidadSubdidiadoTxt = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.SumaTotalTxt = new System.Windows.Forms.TextBox();
            this.SumaCuotaSubsidiadoTxt = new System.Windows.Forms.TextBox();
            this.SumaCuotaContributivoTxt = new System.Windows.Forms.TextBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro:";
            // 
            // FiltroCbm
            // 
            this.FiltroCbm.FormattingEnabled = true;
            this.FiltroCbm.Items.AddRange(new object[] {
            "TODOS",
            "SUBSIDIADO",
            "CONTRIBUTIVO",
            "TOTAL VALOR CUOTAS",
            "TOTAL VALOR POR FECHA",
            "NOMBRE DEL PACIENTE"});
            this.FiltroCbm.Location = new System.Drawing.Point(167, 40);
            this.FiltroCbm.Name = "FiltroCbm";
            this.FiltroCbm.Size = new System.Drawing.Size(145, 21);
            this.FiltroCbm.TabIndex = 1;
            this.FiltroCbm.Text = "TODOS";
            this.FiltroCbm.SelectedIndexChanged += new System.EventHandler(this.FiltroCbm_SelectedIndexChanged);
            // 
            // FiltroLbl
            // 
            this.FiltroLbl.AutoSize = true;
            this.FiltroLbl.Location = new System.Drawing.Point(119, 78);
            this.FiltroLbl.Name = "FiltroLbl";
            this.FiltroLbl.Size = new System.Drawing.Size(35, 13);
            this.FiltroLbl.TabIndex = 2;
            this.FiltroLbl.Text = "label2";
            this.FiltroLbl.Visible = false;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(167, 74);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(145, 20);
            this.NombreTxt.TabIndex = 3;
            this.NombreTxt.Visible = false;
            // 
            // FechaDtp
            // 
            this.FechaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDtp.Location = new System.Drawing.Point(167, 74);
            this.FechaDtp.Name = "FechaDtp";
            this.FechaDtp.Size = new System.Drawing.Size(145, 20);
            this.FechaDtp.TabIndex = 4;
            this.FechaDtp.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 286);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Todos: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad contributivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Canridad Subsidiado: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TodosTxt
            // 
            this.TodosTxt.Location = new System.Drawing.Point(545, 19);
            this.TodosTxt.Name = "TodosTxt";
            this.TodosTxt.Size = new System.Drawing.Size(24, 20);
            this.TodosTxt.TabIndex = 9;
            // 
            // CantidadContributivoTxt
            // 
            this.CantidadContributivoTxt.Location = new System.Drawing.Point(545, 53);
            this.CantidadContributivoTxt.Name = "CantidadContributivoTxt";
            this.CantidadContributivoTxt.Size = new System.Drawing.Size(24, 20);
            this.CantidadContributivoTxt.TabIndex = 10;
            // 
            // CAntidadSubdidiadoTxt
            // 
            this.CAntidadSubdidiadoTxt.Location = new System.Drawing.Point(545, 90);
            this.CAntidadSubdidiadoTxt.Name = "CAntidadSubdidiadoTxt";
            this.CAntidadSubdidiadoTxt.Size = new System.Drawing.Size(24, 20);
            this.CAntidadSubdidiadoTxt.TabIndex = 11;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(464, 446);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(91, 13);
            this.lb1.TabIndex = 12;
            this.lb1.Text = "Suma Cuota total:";
            this.lb1.Visible = false;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(251, 446);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(121, 13);
            this.lb2.TabIndex = 13;
            this.lb2.Text = "Suma Cuota subsidiado:";
            this.lb2.Visible = false;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(34, 446);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(125, 13);
            this.lb3.TabIndex = 14;
            this.lb3.Text = "Suma cuota contributivo:";
            this.lb3.Visible = false;
            // 
            // SumaTotalTxt
            // 
            this.SumaTotalTxt.Location = new System.Drawing.Point(565, 443);
            this.SumaTotalTxt.Name = "SumaTotalTxt";
            this.SumaTotalTxt.ReadOnly = true;
            this.SumaTotalTxt.Size = new System.Drawing.Size(83, 20);
            this.SumaTotalTxt.TabIndex = 15;
            this.SumaTotalTxt.Visible = false;
            // 
            // SumaCuotaSubsidiadoTxt
            // 
            this.SumaCuotaSubsidiadoTxt.Location = new System.Drawing.Point(382, 443);
            this.SumaCuotaSubsidiadoTxt.Name = "SumaCuotaSubsidiadoTxt";
            this.SumaCuotaSubsidiadoTxt.ReadOnly = true;
            this.SumaCuotaSubsidiadoTxt.Size = new System.Drawing.Size(66, 20);
            this.SumaCuotaSubsidiadoTxt.TabIndex = 16;
            this.SumaCuotaSubsidiadoTxt.Visible = false;
            // 
            // SumaCuotaContributivoTxt
            // 
            this.SumaCuotaContributivoTxt.Location = new System.Drawing.Point(169, 443);
            this.SumaCuotaContributivoTxt.Name = "SumaCuotaContributivoTxt";
            this.SumaCuotaContributivoTxt.ReadOnly = true;
            this.SumaCuotaContributivoTxt.Size = new System.Drawing.Size(72, 20);
            this.SumaCuotaContributivoTxt.TabIndex = 17;
            this.SumaCuotaContributivoTxt.Visible = false;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(318, 74);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(31, 20);
            this.BuscarBtn.TabIndex = 18;
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Visible = false;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // ConsultarLiquidacionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(708, 490);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.SumaCuotaContributivoTxt);
            this.Controls.Add(this.SumaCuotaSubsidiadoTxt);
            this.Controls.Add(this.SumaTotalTxt);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.CAntidadSubdidiadoTxt);
            this.Controls.Add(this.CantidadContributivoTxt);
            this.Controls.Add(this.TodosTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FechaDtp);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.FiltroLbl);
            this.Controls.Add(this.FiltroCbm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarLiquidacionFrm";
            this.Text = "ConsultarLiquidacionFrm";
            this.Load += new System.EventHandler(this.ConsultarLiquidacionFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltroCbm;
        private System.Windows.Forms.Label FiltroLbl;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.DateTimePicker FechaDtp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TodosTxt;
        private System.Windows.Forms.TextBox CantidadContributivoTxt;
        private System.Windows.Forms.TextBox CAntidadSubdidiadoTxt;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox SumaTotalTxt;
        private System.Windows.Forms.TextBox SumaCuotaSubsidiadoTxt;
        private System.Windows.Forms.TextBox SumaCuotaContributivoTxt;
        private System.Windows.Forms.Button BuscarBtn;
    }
}