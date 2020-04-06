using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LiquidacionCuotaModeradora
    {
        double salarioMinimo = 980657;
        public double NDeliquidacion { get; set; }
        public double ValorServicio { get; set; }
        public double SalarioDevengado { get; set; }
        public string NombrePaciente { get; set; }
        public string IdentificacionPaciente { get; set; }
        public  string TipoAfiliacion { get; set; }
        public double CuotaModeradora { get; set; }

        public LiquidacionCuotaModeradora(double nDeliquidacion, double valorServicio, double salarioDevengado, string nombrePaciente, string identificacionPaciente, string tipoAfiliacion)
        {
            NDeliquidacion = nDeliquidacion;
            ValorServicio = valorServicio;
            SalarioDevengado = salarioDevengado;
            NombrePaciente = nombrePaciente;
            IdentificacionPaciente = identificacionPaciente;
            TipoAfiliacion = tipoAfiliacion;
        }

        public LiquidacionCuotaModeradora()
        {
        }

        public override string ToString()
        {
            return $"{NDeliquidacion};{ValorServicio};{SalarioDevengado};{NombrePaciente};{IdentificacionPaciente};{TipoAfiliacion};{CuotaModeradora}"; 
        }
        public void CalcularCuota()
        {
            CuotaModeradora = CalcularTarifa ()* ValorServicio;
            if (CuotaModeradora>CalcularTope())
            {
                CuotaModeradora = CalcularTope();
            }
        }
        public double CalcularTope()
        {
            if ((TipoAfiliacion.ToUpper()).Equals("SUBSIDIADO")) return 200000;
            else
            {
                if (SalarioDevengado < (salarioMinimo * 2)) return 250000;
                else
                {
                    if (SalarioDevengado >= (salarioMinimo * 2) && salarioMinimo <= (salarioMinimo * 5)) return 900000;
                    else
                    {
                        if (SalarioDevengado > (salarioMinimo * 5)) return 1500000;
                    }
                }

            }
            return 0;

        }
        public double CalcularTarifa()
        {
            if ((TipoAfiliacion.ToUpper()).Equals("SUBSIDIADO")) return 0.05;
            else
            {
                if (SalarioDevengado < (salarioMinimo * 2)) return 0.15;
                else
                {
                    if (SalarioDevengado >= (salarioMinimo * 2) && salarioMinimo<=(salarioMinimo*5)) return 0.20;
                    else
                    {
                        if (SalarioDevengado > (salarioMinimo * 5)) return 0.25;
                    }
                }
                
            }
            return 0;
        }
        public string SeAplicoTope()
        {
            if (CuotaModeradora > CalcularTope()) return "Si";
            else return "No";
        }
        public string Imprimir()
        {
            return $"Identificacion del paciente:{IdentificacionPaciente}\n Tipo de afiliacion:{TipoAfiliacion}\n Salario Devengado por el paciente:{SalarioDevengado}\n valor del servicio:{ValorServicio}\n Tarifa:{CalcularTarifa()}\n" +
                $"Se aplico tope:{SeAplicoTope()}\n Valor real de la cuota:{CalcularTarifa() * ValorServicio}\n Valor Cuota Moderadora:{CuotaModeradora}\n";
        }
    }
}
