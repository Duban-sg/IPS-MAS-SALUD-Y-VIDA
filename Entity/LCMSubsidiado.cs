using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LCMSubsidiado : LiquidacionCuotaModeradora
    {
        public LCMSubsidiado()
        {
            Tarifa = 0.05;
        }
        public override void CalcularCuota()
        {
            CuotaModeradora = Tarifa * ValorServicio;
            ValorReal = CuotaModeradora;
            SeAplicoTope();
        }
        public override void SeAplicoTope()
        {
            if (CuotaModeradora > 200000)
            {
                ValorReal = CuotaModeradora;
                CuotaModeradora = 200000;
                TopeAplicado = "si";
            }
            else
            {
                TopeAplicado = "no";
            }
            
        }

    }
}
