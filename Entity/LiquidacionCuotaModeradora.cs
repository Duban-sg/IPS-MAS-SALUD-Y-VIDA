using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidacionCuotaModeradora
    {
        public double salarioMinimo = 980657;
        public double NDeliquidacion { get; set; }
        public double ValorServicio { get; set; }
        public double SalarioDevengado { get; set; }
        public string NombrePaciente { get; set; }
        public string IdentificacionPaciente { get; set; }
        public string TipoAfiliacion { get; set; }
        public double CuotaModeradora { get; set; }
        public double Tarifa { get; set; }
        public DateTime Fecha { get; set; }
        public double ValorReal { get; set; }
        public string TopeAplicado { get; set; }

        protected LiquidacionCuotaModeradora(double nDeliquidacion, double valorServicio, double salarioDevengado, string nombrePaciente, string identificacionPaciente, string tipoAfiliacion,DateTime fecha)
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
            return$"{NDeliquidacion};{ValorServicio};{SalarioDevengado};{NombrePaciente};{IdentificacionPaciente};{TipoAfiliacion};{CuotaModeradora};{Tarifa};{Fecha};{TopeAplicado};{Tarifa*ValorServicio}\n";
        }
        public abstract void CalcularCuota();
        public abstract void SeAplicoTope();
        
    }
}
