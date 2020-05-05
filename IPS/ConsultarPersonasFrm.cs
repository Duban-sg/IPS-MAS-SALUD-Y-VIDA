using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entity;
using System.Windows.Forms;

namespace IPS
{
    public partial class ConsultarPersonasFrm : Form
    {
        PacienteService ServicePaciente = new PacienteService();
        public ConsultarPersonasFrm()
        {
            InitializeComponent();
            LLenarDataGribView();
            LLenarCantidades();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LLenarDataGribView();
            LLenarCantidades();
        }
        public void LLenarDataGribView()
        {
            dataGridView1.DataSource = null;
            if (FiltroCbmx.Text=="SUBSIDIADO")
            {
                dataGridView1.DataSource = ServicePaciente.FiltroPacientes(FiltroCbmx.Text); 
            }
            else if (FiltroCbmx.Text== "CONTRIBUTIVO")
            {
                dataGridView1.DataSource = ServicePaciente.FiltroPacientes(FiltroCbmx.Text);
            }
            else
            {
                dataGridView1.DataSource = ServicePaciente.FiltroPacientes("  ");
            }
        }
        public void LLenarCantidades()
        {
            if (FiltroCbmx.Text == "SUBSIDIADO")
            {
                TodosTxt.Text = ServicePaciente.CantidadConFiltro("SUBSIDIADO").ToString();
                CantidadSubsidiadosTxt.Text = ServicePaciente.CantidadConFiltro("SUBSIDIADO").ToString();
                CantidadContribuyentesTxt.Text = "0";
            }
            else if (FiltroCbmx.Text == "CONTRIBUTIVO")
            {
                TodosTxt.Text = ServicePaciente.CantidadConFiltro("CONTRIBUTIVO").ToString();
                CantidadSubsidiadosTxt.Text = "0";
                CantidadContribuyentesTxt.Text = ServicePaciente.CantidadConFiltro("CONTRIBUTIVO").ToString();
            }
            else
            {
                TodosTxt.Text = ServicePaciente.CantidadConFiltro(" ").ToString();
                CantidadSubsidiadosTxt.Text = ServicePaciente.CantidadConFiltro("SUBSIDIADO").ToString();
                CantidadContribuyentesTxt.Text = ServicePaciente.CantidadConFiltro("CONTRIBUTIVO").ToString();
            }
        }
    }
}
