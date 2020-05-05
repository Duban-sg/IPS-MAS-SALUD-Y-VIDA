using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Paciente
    {
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Identificacion { get; set; }
        public string TipoAfiliacion { get; set; }
        public double SalarioDevengado { get; set; }

        public Paciente(string nombre, string apellido1, string apellido2, string identificacion, string tipoAfiliacion, double salarioDevengado)
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Identificacion = identificacion;
            TipoAfiliacion = tipoAfiliacion;
            SalarioDevengado = salarioDevengado;
        }

        public Paciente()
        {
            Apellido2 = "   ";
        }

        public override string ToString()
        {
            return $"{Nombre};{Apellido1};{Apellido2};{Identificacion};{TipoAfiliacion};{SalarioDevengado}\n";
        }
    }
}
