using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class LiquidacionCuotaModeradoraService
    {
        private LiquidacionCuotaModeradoraRepository lcmr = new LiquidacionCuotaModeradoraRepository();

        public string GuardarLiquidacion(LiquidacionCuotaModeradora lq)
        {
            try
            {
                lcmr.Guardar(lq);
                return "Se guardo correctamente la informacion";
            }
            catch (Exception e)
            {

                return $"Error:{e}";
            }



        }

        public LiquidacionCuotaModeradora BuscarLiquidacion(string Identificacion)
        {
            try
            {
                return lcmr.BuscarLiquidacion(Identificacion);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool EsxiteLIquidacion(string Identificacion)
        {
            if (BuscarLiquidacion(Identificacion) != null) return true;
            return false;

        }
        public IList<LiquidacionCuotaModeradora> BuscarLiquidaciones()
        {
            try
            {
                return lcmr.leer();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string eliminar(string identificaion)
        {
            try
            {
                if ((lcmr.BuscarLiquidacion(identificaion)) != null)
                {
                    lcmr.eliminar(identificaion);
                    return "Se elimino la informacion correctamente";
                }
                else return "No hay registro de la liquidacion";
            }
            catch (Exception e)
            {

                return $"Error{e}";
            }



        }
        public string modificar(string Nliquidacion, double ValorServicio)
        {
            try
            {
                if ((lcmr.BuscarLiquidacion(Nliquidacion)) != null)
                {
                    LiquidacionCuotaModeradora liquidacion = lcmr.BuscarLiquidacion(Nliquidacion);
                    liquidacion.ValorServicio = ValorServicio;
                    liquidacion.CalcularCuota();
                    lcmr.Modificar(liquidacion);
                    return "Se modificaron los datos con exito";

                }
                else return "La liquidacion no ha sido registrada";


            }
            catch (Exception e)
            {

                return $"Error {e}";
            }
        }

        public int CatidadLiquidaciones(string texto)
        {
            try
            {
                return lcmr.CatidadLiquidaciones(texto);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IList<LiquidacionCuotaModeradora> FiltroLiquidacionCuotaModeradora(string texto)
        {
            try
            {
                return lcmr.FiltroLiquidacionCuotaModeradora(texto);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public String[] SumaCuotaModeradora()
        {
            try
            {
                string[] suma = new string[3];
            
                suma[0] = lcmr.SumaCuotaModeradora("qweq").ToString();
                suma[1] = lcmr.SumaCuotaModeradora("SUBSIDIADO").ToString();
                suma[2] = lcmr.SumaCuotaModeradora("CONTRIBUTIVO").ToString();
                
                

                return suma;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<LiquidacionCuotaModeradora> FiltroLiquidacionPorFecha(string texto, int mes, int año)
        {
            try
            {
                return lcmr.FiltroLiquidacionPorFecha(texto,mes,año);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int CantidadPorFecha(string texto, int mes, int año)
        {
            try
            {
                return lcmr.CantidadPorFecha(texto,mes,año);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public double SumaPorFecha(string texto, int mes, int año)
        {
            try
            {
                return lcmr.SumaPorFecha(texto,mes,año);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IList<LiquidacionCuotaModeradora> FiltroPorNombre(string texto)
        {
            try
            {
                return lcmr.FiltroPorNombre(texto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

   

}
