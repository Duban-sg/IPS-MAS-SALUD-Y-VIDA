using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;


namespace DAL
{
    public class LiquidacionCuotaModeradoraRepository
    {
        private string ruta = @"LiquidacionCuota.txt";
        private List<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras = new List<LiquidacionCuotaModeradora>();


        public void Guardar(LiquidacionCuotaModeradora lcm)
        {
            FileStream hilo = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(hilo);
            escritor.Write(lcm.ToString());
            escritor.Close();
            hilo.Close();
        }
        public List<LiquidacionCuotaModeradora> leer()
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
            foreach (LiquidacionCuotaModeradora item in liquidacionCuotaModeradoras)
            {
                if (item.NDeliquidacion == double.Parse(Nliquidacion))
                {
                    return item;
                }
            }
            return null;
        }
        public void eliminar(string Nliquidacion)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = leer();
            FileStream hilo = new FileStream(ruta,FileMode.Create);
            foreach (LiquidacionCuotaModeradora item in liquidacionCuotaModeradoras)
            {
                if ((item.NDeliquidacion.Equals(Nliquidacion)) != false) Guardar(item);

            }
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
            LiquidacionCuotaModeradora lcm = new LiquidacionCuotaModeradora();
            string[] separado = text.Split(';');
            lcm.NDeliquidacion = double.Parse(separado[0]);
            lcm.ValorServicio = double.Parse(separado[1]);
            lcm.SalarioDevengado = double.Parse(separado[2]);
            lcm.NombrePaciente = separado[3];
            lcm.IdentificacionPaciente = separado[4];
            lcm.TipoAfiliacion = separado[5];

            return lcm;
        }
    }
}
