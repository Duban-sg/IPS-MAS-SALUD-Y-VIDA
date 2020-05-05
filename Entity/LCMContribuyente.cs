using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LCMContribuyente : LiquidacionCuotaModeradora
    {
        public LCMContribuyente()
        {
            CalcularTarifa();
        }

        public void CalcularTarifa()
        {
            if (SalarioDevengado < (2 * salarioMinimo)) Tarifa = 0.15;
            else if (SalarioDevengado >= (2 * salarioMinimo) && SalarioDevengado<=(5 * salarioMinimo)) Tarifa = 0.20;
            else if (SalarioDevengado > (5 * salarioMinimo)) Tarifa = 0.20;
        }
        public override void CalcularCuota()
        {
            CuotaModeradora = ValorServicio * Tarifa;
            ValorReal = CuotaModeradora;
            SeAplicoTope();
        }
        public override void SeAplicoTope()
        {
            if (SalarioDevengado < (2 * salarioMinimo))
            {
                if (CuotaModeradora >250000)
                {
                    ValorReal = CuotaModeradora;
                    CuotaModeradora = 250000;
                    TopeAplicado = "si";
                    
                }
            }
            else if (SalarioDevengado >= (2 * salarioMinimo) && SalarioDevengado <= (5 * salarioMinimo))
            {
                if (CuotaModeradora > 900000)
                {
                    ValorReal = CuotaModeradora;
                    CuotaModeradora = 900000;
                    TopeAplicado = "si";
                }
            }
            else if (SalarioDevengado > (5 * salarioMinimo))
            {
                if (CuotaModeradora > 250000)
                {
                    ValorReal = CuotaModeradora;
                    CuotaModeradora = 1500000;
                    TopeAplicado = "si";
                }
            }
            else TopeAplicado = "no";
            
        }
        
    }
}
