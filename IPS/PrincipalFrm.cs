using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPS
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarPersonaBtn_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new RegistrarPersonaFrm());
        }


        public void AbrirFormulario(object formulario)
        {
            if (ContenidoPnl.Controls.Count > 0) ContenidoPnl.Controls.RemoveAt(0);
            Form contenido = formulario as Form;
            contenido.TopLevel = false;
            contenido.Dock = DockStyle.Fill;
            this.ContenidoPnl.Controls.Add(contenido);
            this.ContenidoPnl.Tag = contenido;
            contenido.Show();
        }

        private void PrincipalFrm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new RegistrarLiquidacionFrm());
        }

        private void ConsultarRegistrosBtn_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ConsultarPersonasFrm());
        }

        private void ConsultarLiquidacionBtn_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ConsultarLiquidacionFrm());
        }
    }
}
