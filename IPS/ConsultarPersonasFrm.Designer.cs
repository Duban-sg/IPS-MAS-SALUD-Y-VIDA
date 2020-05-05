namespace IPS
{
    partial class ConsultarPersonasFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FiltroCbmx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TodosTxt = new System.Windows.Forms.TextBox();
            this.CantidadContribuyentesTxt = new System.Windows.Forms.TextBox();
            this.CantidadSubsidiadosTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(223, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 372);
            this.dataGridView1.TabIndex = 3;
            // 
            // FiltroCbmx
            // 
            this.FiltroCbmx.FormattingEnabled = true;
            this.FiltroCbmx.Items.AddRange(new object[] {
            "TODOS",
            "SUBSIDIADO",
            "CONTRIBUTIVO"});
            this.FiltroCbmx.Location = new System.Drawing.Point(94, 38);
            this.FiltroCbmx.Name = "FiltroCbmx";
            this.FiltroCbmx.Size = new System.Drawing.Size(123, 21);
            this.FiltroCbmx.TabIndex = 4;
            this.FiltroCbmx.Text = "TODOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Todos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad Contribuyentes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad subsidiados:";
            // 
            // TodosTxt
            // 
            this.TodosTxt.Enabled = false;
            this.TodosTxt.Location = new System.Drawing.Point(540, 10);
            this.TodosTxt.Name = "TodosTxt";
            this.TodosTxt.Size = new System.Drawing.Size(28, 20);
            this.TodosTxt.TabIndex = 8;
            // 
            // CantidadContribuyentesTxt
            // 
            this.CantidadContribuyentesTxt.Enabled = false;
            this.CantidadContribuyentesTxt.Location = new System.Drawing.Point(540, 35);
            this.CantidadContribuyentesTxt.Name = "CantidadContribuyentesTxt";
            this.CantidadContribuyentesTxt.Size = new System.Drawing.Size(28, 20);
            this.CantidadContribuyentesTxt.TabIndex = 9;
            // 
            // CantidadSubsidiadosTxt
            // 
            this.CantidadSubsidiadosTxt.Enabled = false;
            this.CantidadSubsidiadosTxt.Location = new System.Drawing.Point(540, 62);
            this.CantidadSubsidiadosTxt.Name = "CantidadSubsidiadosTxt";
            this.CantidadSubsidiadosTxt.Size = new System.Drawing.Size(28, 20);
            this.CantidadSubsidiadosTxt.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.panel1.Location = new System.Drawing.Point(297, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 40);
            this.panel1.TabIndex = 11;
            // 
            // ConsultarPersonasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(708, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CantidadSubsidiadosTxt);
            this.Controls.Add(this.CantidadContribuyentesTxt);
            this.Controls.Add(this.TodosTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltroCbmx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarPersonasFrm";
            this.Text = "ConsultarPersonasFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox FiltroCbmx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TodosTxt;
        private System.Windows.Forms.TextBox CantidadContribuyentesTxt;
        private System.Windows.Forms.TextBox CantidadSubsidiadosTxt;
        private System.Windows.Forms.Panel panel1;
    }
}