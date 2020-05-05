using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;
using System.Windows.Forms;

namespace IPS
{
    public partial class RegistrarPersonaFrm : Form
    {
        PacienteService PacienteService = new PacienteService();


        public RegistrarPersonaFrm()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarPersonaFrm_Load(object sender, EventArgs e)
        {

        }




        public void limpiar()
        {
            IdentificacionTxt.Text = "";
            NombreTxt.Text = "";
            PrimerApellidoTxt.Text = "";
            SegundoApellidoTxt.Text = "";
            TipoAliacionCbm.SelectedIndex = 0;
            SalarioDevengadoTxt.Text = "";
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private bool CampoLLenos()
        {
            if (string.IsNullOrEmpty(IdentificacionTxt.Text)) return false;
            else if (string.IsNullOrEmpty(NombreTxt.Text)) return false;
            else if (string.IsNullOrEmpty(PrimerApellidoTxt.Text)) return false;
            else if (string.IsNullOrEmpty(TipoAliacionCbm.Text)) return false;
            else if (string.IsNullOrEmpty(SalarioDevengadoTxt.Text) || SalarioDevengadoTxt.Text=="0") return false;
            else return true;
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (CampoLLenos()==true)
            {
                if (ValidarCedula(IdentificacionTxt.Text) && ValidesSalario(SalarioDevengadoTxt.Text))
                {
                    MessageBox.Show(PacienteService.Guardar(InstanciarPaciente()));
                    limpiar();
                }
                
            }
            else
            {
                MessageBox.Show("Porfavor no deje ningun campo importante vacio, estan señalados con: (*)"," ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void SegundoApellidoTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        public Paciente InstanciarPaciente()
        {
            Paciente paciente = new Paciente();

            paciente.Identificacion = IdentificacionTxt.Text;
            paciente.Nombre = NombreTxt.Text;
            paciente.Apellido1 = PrimerApellidoTxt.Text;
            paciente.Apellido2 = SegundoApellidoTxt.Text;
            paciente.TipoAfiliacion = TipoAliacionCbm.Text;
            paciente.SalarioDevengado = double.Parse(SalarioDevengadoTxt.Text);
            return paciente;
        }

        public bool ValidarCedula(string identificacion)
        {
            RespuestaValides respuesta = PacienteService.ValidarCedula(identificacion);
            if (respuesta.valides == true) return true;
            else
            {
                MessageBox.Show(respuesta.error);
                return respuesta.valides;
            }
        }
        public bool ValidesSalario(string salario)
        {
            if (PacienteService.EsNumero(salario)==false)
            {
                MessageBox.Show("En el Campo salario solo puede haber numeros");
                return false;
            }
            return true;
        }

        private void SalarioDevengadoTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
