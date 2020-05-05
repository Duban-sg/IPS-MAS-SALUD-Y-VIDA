using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using Entity;


namespace DAL
{
    public class LiquidacionCuotaModeradoraRepository
    {
        private string ruta = @"LiquidacionCuota.txt";
        private IList<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras = new List<LiquidacionCuotaModeradora>();


        public void Guardar(LiquidacionCuotaModeradora lcm)
        {
            FileStream hilo = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(hilo);
            escritor.Write(lcm.ToString());
            escritor.Close();
            hilo.Close();
        }
        public void GuardarLista(IList<LiquidacionCuotaModeradora> lcm)
        {
            FileStream hilo = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(hilo);
            foreach (var item in lcm)
            {
                escritor.Write(item.ToString());
            }
            escritor.Close();
            hilo.Close();
        }
        public IList<LiquidacionCuotaModeradora> leer()
        {
            string linea;
            liquidacionCuotaModeradoras.Clear();
            FileStream hilo = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(hilo);
            while ((linea = lector.ReadLine()) != null)
            {
                liquidacionCuotaModeradoras.Add(Separador(linea));
            }
            lector.Close();
            hilo.Close();
            return liquidacionCuotaModeradoras;
        }
        public LiquidacionCuotaModeradora BuscarLiquidacion(string Nliquidacion)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = leer();

            FileStream hilo = new FileStream(ruta, FileMode.OpenOrCreate);
            hilo.Close();
            
            return liquidacionCuotaModeradoras.Where(p=>p.NDeliquidacion==double.Parse(Nliquidacion)).FirstOrDefault();
        }
        


        public void eliminar(string Nliquidacion)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = leer();
            FileStream hilo = new FileStream(ruta,FileMode.Create);
            GuardarLista(liquidacionCuotaModeradoras.Where(p=>p.NDeliquidacion!=double.Parse(Nliquidacion)).ToList());
            hilo.Close();
        }
        public void Modificar(LiquidacionCuotaModeradora lqcm) {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = leer();
            FileStream hilo = new FileStream(ruta,FileMode.Create);
            hilo.Close();
            foreach (LiquidacionCuotaModeradora item in liquidacionCuotaModeradoras)
            {
                if (item.NDeliquidacion == lqcm.NDeliquidacion) Guardar(lqcm);
                else Guardar(item);
            }
        }

        public LiquidacionCuotaModeradora Separador(string text)
        {
            string[] separado = text.Split(';');
            LiquidacionCuotaModeradora lcm = QueTipoEs(separado[5]);
            lcm.NDeliquidacion = double.Parse(separado[0]);
            lcm.ValorServicio = double.Parse(separado[1]);
            lcm.SalarioDevengado = double.Parse(separado[2]);
            lcm.NombrePaciente = separado[3];
            lcm.IdentificacionPaciente = separado[4];
            lcm.TipoAfiliacion = separado[5];
            lcm.CuotaModeradora = double.Parse(separado[6]);
            lcm.Tarifa = double.Parse(separado[7]) ;
            lcm.Fecha = DateTime.Parse(separado[8]);
            lcm.TopeAplicado = separado[9];
            lcm.ValorReal = double.Parse(separado[10]);

            return lcm;
        }

        public LiquidacionCuotaModeradora QueTipoEs(string tipo)
        {
            if (tipo.ToUpper() == "SUBCIDIADO") return new LCMSubsidiado();
            else return new LCMContribuyente();
        }

        public int CatidadLiquidaciones(string texto)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = leer();

            if (texto == "CONTRIBUTIVO") return liquidacionCuotaModeradoras.Count(p => p.TipoAfiliacion == texto);
            else if (texto == "SUBSIDIADO") return liquidacionCuotaModeradoras.Count(p => p.TipoAfiliacion == texto);
            else return liquidacionCuotaModeradoras.Count();
        }
        public IList<LiquidacionCuotaModeradora> FiltroLiquidacionCuotaModeradora (string texto)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = leer();

            if (texto == "CONTRIBUTIVO") return liquidacionCuotaModeradoras.Where(p => p.TipoAfiliacion == texto).ToList();
            else return liquidacionCuotaModeradoras.Where(p => p.TipoAfiliacion == texto).ToList();
           
        }

        public double SumaCuotaModeradora(string texto)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = leer();

            if (texto == "CONTRIBUTIVO") return liquidacionCuotaModeradoras.Where(p=>p.TipoAfiliacion==texto).Sum(p=>p.CuotaModeradora);
            else if (texto == "SUBSIDIADO") return liquidacionCuotaModeradoras.Where(p => p.TipoAfiliacion == texto).Sum(p => p.CuotaModeradora);
            else return liquidacionCuotaModeradoras.Sum(p => p.CuotaModeradora);
        }

        public double SumaPorFecha(string texto,int mes, int año)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = leer();

            if (texto == "CONTRIBUTIVO") return liquidacionCuotaModeradoras.Where(p => p.TipoAfiliacion == texto && p.Fecha.Month == mes && p.Fecha.Year == año).Sum(p => p.CuotaModeradora);
            else if (texto == "SUBSIDIADO") return liquidacionCuotaModeradoras.Where(p => p.TipoAfiliacion == texto && p.Fecha.Month == mes && p.Fecha.Year == año).Sum(p => p.CuotaModeradora);
            else return liquidacionCuotaModeradoras.Sum(p => p.CuotaModeradora);
        }

        public int CantidadPorFecha(string texto, int mes, int año)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = leer();

            if (texto == "CONTRIBUTIVO") return liquidacionCuotaModeradoras.Count(p => p.TipoAfiliacion == texto && p.Fecha.Month==mes && p.Fecha.Year==año);
            else if (texto == "SUBSIDIADO") return liquidacionCuotaModeradoras.Count(p => p.TipoAfiliacion == texto && p.Fecha.Month == mes && p.Fecha.Year == año);
            else return liquidacionCuotaModeradoras.Count(p=>p.Fecha.Month == mes && p.Fecha.Year == año);
        }

        public IList<LiquidacionCuotaModeradora> FiltroLiquidacionPorFecha(string texto,int mes , int año)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = leer();

            if (texto == "CONTRIBUTIVO") return liquidacionCuotaModeradoras.Where(p => p.TipoAfiliacion == texto && p.Fecha.Month == mes && p.Fecha.Year == año).ToList();
            else if (texto == "SUBSIDIADO") return liquidacionCuotaModeradoras.Where(p => p.TipoAfiliacion == texto && p.Fecha.Month == mes && p.Fecha.Year == año).ToList();
            else return liquidacionCuotaModeradoras.Where(p => p.Fecha.Month == mes && p.Fecha.Year == año).ToList();
        }

        public IList<LiquidacionCuotaModeradora> FiltroPorNombre(string texto)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = leer();

            return liquidacionCuotaModeradoras.Where(p=>p.NombrePaciente.Contains(texto)).ToList();
        }

    }
}
