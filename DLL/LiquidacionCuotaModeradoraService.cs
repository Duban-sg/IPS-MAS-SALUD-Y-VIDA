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
        public List<LiquidacionCuotaModeradora> VerLiquidaciones()
        {
            try
            {
                return lcmr.leer();
            }
            catch (Exception e)
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
        public string modificar(string Nliquidacion,double ValorServicio)
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

    }
}
