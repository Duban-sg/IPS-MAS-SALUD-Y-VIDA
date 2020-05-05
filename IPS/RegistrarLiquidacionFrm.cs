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
    public partial class RegistrarLiquidacionFrm : Form
    {
        PacienteService PacienteService = new PacienteService();
        LiquidacionCuotaModeradoraService serviceLCM = new LiquidacionCuotaModeradoraService(); 

        public RegistrarLiquidacionFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PacienteService.EsNumero(ValorDelServicioTxt.Text) && PacienteService.EsNumero(NumeroDeLiquidacionTxt.Text))
            {
                if (serviceLCM.EsxiteLIquidacion(NumeroDeLiquidacionTxt.Text)==false)
                {
                    MessageBox.Show(serviceLCM.GuardarLiquidacion(InstanciarLiquidacion()));
                }
                else
                {
                    MessageBox.Show("El numero de liquidacion ya se encuentra registrado");
                }
                
            }
            else
            {
                MessageBox.Show("Los campos (NumeroLiquidacion) y (Valor servicio) tienen que estar llenos con caracteres numericos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCedula(IdentificacionTxt.Text))
            {
                if (PacienteService.existe(IdentificacionTxt.Text))
                {
                    LLenarCamposExistentes(PacienteService.Buscar(IdentificacionTxt.Text));
                    ActivarCampos();
                }
                else
                {
                    MessageBox.Show("La identificacion ingresada no existe en el registro");
                }
            }            
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

        public void limpiar()
        {
            IdentificacionTxt.Text = "";
            NombrePacienteTxt.Text = "";
            SalarioDevengadoTxt.Text = "";
            NumeroDeLiquidacionTxt.Text = "";
            ValorDelServicioTxt.Text = "";
            CuotaModeradoraTxt.Text = "";
            TipoAfiliacionTxt.Text = "  ";
            FechaDeLIquidacionDtp.Value = DateTime.Parse("1 / 05 / 2020");   
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            limpiar();
            DesactivarCampos();
        }
        public void LLenarCamposExistentes(Paciente paciente)
        {
            NombrePacienteTxt.Text = $"{paciente.Nombre} {paciente.Apellido1} {paciente.Apellido2}";
            TipoAfiliacionTxt.Text = paciente.TipoAfiliacion;
            SalarioDevengadoTxt.Text = paciente.SalarioDevengado.ToString();
        }
        public void ActivarCampos()
        {
            NumeroDeLiquidacionTxt.Enabled = true;
            FechaDeLIquidacionDtp.Enabled = true;
            ValorDelServicioTxt.Enabled = true;
            LimpiarBtn.Enabled = true;
            GuardarBtn.Enabled = true;
        }
        public void DesactivarCampos()
        {
            NombrePacienteTxt.Enabled = false;
            SalarioDevengadoTxt.Enabled = false;
            NumeroDeLiquidacionTxt.Enabled = false;
            ValorDelServicioTxt.Enabled = false;
            CuotaModeradoraTxt.Enabled = false;
            TipoAfiliacionTxt.Enabled = false;
            FechaDeLIquidacionDtp.Enabled = false;
            LimpiarBtn.Enabled = false;
            GuardarBtn.Enabled = false;
        }

        public LiquidacionCuotaModeradora InstanciarLiquidacion()
        {
            LiquidacionCuotaModeradora liquidacion = TipoLiquidacion(TipoAfiliacionTxt.Text);
            liquidacion.NombrePaciente = NombrePacienteTxt.Text;
            liquidacion.IdentificacionPaciente = IdentificacionTxt.Text;
            liquidacion.NDeliquidacion = double.Parse( NumeroDeLiquidacionTxt.Text);
            liquidacion.SalarioDevengado = double.Parse(SalarioDevengadoTxt.Text);
            liquidacion.Fecha = FechaDeLIquidacionDtp.Value;
            liquidacion.TipoAfiliacion = TipoAfiliacionTxt.Text;
            liquidacion.ValorServicio = double.Parse(ValorDelServicioTxt.Text);
            liquidacion.CalcularCuota();

            CuotaModeradoraTxt.Text = liquidacion.CuotaModeradora.ToString();

            return liquidacion;

        }

        public LiquidacionCuotaModeradora TipoLiquidacion(string texto)
        {
            if (texto == "SUBSIDIADO") return new LCMSubsidiado();
            else return new LCMContribuyente();
        }

    }
}
