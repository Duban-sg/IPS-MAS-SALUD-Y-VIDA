using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Windows.Forms;

namespace IPS
{
    public partial class ConsultarLiquidacionFrm : Form
    {
        LiquidacionCuotaModeradoraService ServiceLCM = new LiquidacionCuotaModeradoraService();
       


        public ConsultarLiquidacionFrm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FiltroCbm_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            MostrarFechaOTxt();
            ComportaminetoLbl();
            DesactivarTotales();
            ResetearCantidades();
            LLenarDataGrid();
            LLenarCantidad();
            
            
        }

        public void LLenarCantidad()
        {
            if (FiltroCbm.SelectedIndex == 0)
            {
                TodosTxt.Text = ServiceLCM.CatidadLiquidaciones("").ToString();
                CantidadContributivoTxt.Text = ServiceLCM.CatidadLiquidaciones("CONTRIBUTIVO").ToString();
                CAntidadSubdidiadoTxt.Text = ServiceLCM.CatidadLiquidaciones("SUBSIDIADO").ToString();
            }
            else if (FiltroCbm.SelectedIndex == 1)
            {
                TodosTxt.Text = ServiceLCM.CatidadLiquidaciones("SUBSIDIADO").ToString();
                CantidadContributivoTxt.Text = "0";
                CAntidadSubdidiadoTxt.Text = ServiceLCM.CatidadLiquidaciones("SUBSIDIADO").ToString();
            }
            else if (FiltroCbm.SelectedIndex == 2)
            {
                TodosTxt.Text = ServiceLCM.CatidadLiquidaciones("CONTRIBUTIVO").ToString();
                CantidadContributivoTxt.Text = ServiceLCM.CatidadLiquidaciones("CONTRIBUTIVO").ToString();
                CAntidadSubdidiadoTxt.Text = "0";
            }
            else if (FiltroCbm.SelectedIndex == 3)
            {
                TodosTxt.Text = ServiceLCM.CatidadLiquidaciones("").ToString();
                CantidadContributivoTxt.Text = ServiceLCM.CatidadLiquidaciones("CONTRIBUTIVO").ToString();
                CAntidadSubdidiadoTxt.Text = ServiceLCM.CatidadLiquidaciones("SUBSIDIADO").ToString();
            }


        }
        public void LLenarDataGrid()
        {
            if (FiltroCbm.SelectedIndex == 0)dataGridView1.DataSource = ServiceLCM.BuscarLiquidaciones(); 
            else if (FiltroCbm.SelectedIndex == 1)
            {
                dataGridView1.DataSource = ServiceLCM.FiltroLiquidacionCuotaModeradora("SUBSIDIADO");
            }
            else if (FiltroCbm.SelectedIndex == 2)
            {
                dataGridView1.DataSource = ServiceLCM.FiltroLiquidacionCuotaModeradora("CONTRIBUTIVO");
            }
            else if (FiltroCbm.SelectedIndex == 3)
            {
                dataGridView1.DataSource = dataGridView1.DataSource = ServiceLCM.BuscarLiquidaciones();
                MostrarTotales();

            }
        }
        public void ResetearCantidades()
        {
            TodosTxt.Text = "0";
            CantidadContributivoTxt.Text = "0";
            CAntidadSubdidiadoTxt.Text = "0";
        }

        public void DesactivarTotales()
        {
            lb1.Visible = false;
            lb2.Visible = false;
            lb3.Visible = false;
            SumaTotalTxt.Visible = false;
            SumaCuotaSubsidiadoTxt.Visible = false;
            SumaCuotaContributivoTxt.Visible = false;
        }
        public void MostrarTotales()
        {
            lb1.Visible = true;
            lb2.Visible = true;
            lb3.Visible = true;
            SumaTotalTxt.Visible = true;
            SumaCuotaSubsidiadoTxt.Visible = true;
            SumaCuotaContributivoTxt.Visible = true;

            SumaTotalTxt.Text = ServiceLCM.SumaCuotaModeradora()[0];
            SumaCuotaSubsidiadoTxt.Text = ServiceLCM.SumaCuotaModeradora()[1];
            SumaCuotaContributivoTxt.Text = ServiceLCM.SumaCuotaModeradora()[2];
        }

        public void ComportaminetoLbl()
        {
            if (FiltroCbm.SelectedIndex==4)
            {
                FiltroLbl.Text = "Fecha:";
                FiltroLbl.Visible = true;
            }
            else if (FiltroCbm.SelectedIndex==5)
            {
                FiltroLbl.Text = "Nombre:";
                FiltroLbl.Visible = true;
            }else FiltroLbl.Visible = false; 

        }
        public void MostrarFechaOTxt()
        {
            if (FiltroCbm.SelectedIndex == 4)
            {
                NombreTxt.Visible = false;
                FechaDtp.Visible = true;
                BuscarBtn.Visible = true;
            }
            else if (FiltroCbm.SelectedIndex == 5)
            {
                FechaDtp.Visible = false;
                NombreTxt.Visible = true;
                BuscarBtn.Visible = true;
            }
            else
            {
                FechaDtp.Visible = false;
                NombreTxt.Visible = false;
                BuscarBtn.Visible = false;
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            if (FiltroCbm.SelectedIndex==4)
            {
                LLenarPorMesAño();
                LLenarCantidadPorMesAño();
                SumaPorMesAño();
            }
            else if (FiltroCbm.SelectedIndex==5)
            {
                dataGridView1.DataSource = ServiceLCM.FiltroPorNombre(NombreTxt.Text);
            }
        }

        public void LLenarPorMesAño()
        {
            dataGridView1.DataSource = ServiceLCM.FiltroLiquidacionPorFecha("", FechaDtp.Value.Month, FechaDtp.Value.Year);
        }
        public void LLenarCantidadPorMesAño()
        {
            TodosTxt.Text = ServiceLCM.CantidadPorFecha("hola", FechaDtp.Value.Month, FechaDtp.Value.Year).ToString();
            CantidadContributivoTxt.Text = ServiceLCM.CantidadPorFecha("CONTRIBUTIVO", FechaDtp.Value.Month, FechaDtp.Value.Year).ToString();
            CAntidadSubdidiadoTxt.Text = ServiceLCM.CantidadPorFecha("SUBSIDIADO", FechaDtp.Value.Month, FechaDtp.Value.Year).ToString();
        }
        public void SumaPorMesAño()
        {
            SumaTotalTxt.Text = ServiceLCM.SumaPorFecha("como", FechaDtp.Value.Month, FechaDtp.Value.Year).ToString();
            SumaCuotaSubsidiadoTxt.Text = ServiceLCM.SumaPorFecha("SUBSIDIADO", FechaDtp.Value.Month, FechaDtp.Value.Year).ToString();
            SumaCuotaContributivoTxt.Text = ServiceLCM.SumaPorFecha("CONTRIBUTIVO", FechaDtp.Value.Month, FechaDtp.Value.Year).ToString();
        }
    }
}
