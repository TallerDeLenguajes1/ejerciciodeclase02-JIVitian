using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico_TL2_Semena4_
{
    public enum TipoExtraccion
    {
        CajeroHumano = 1,
        CajeroAutomatico = 2
    }
    public interface Cuenta
    {
        public int Insercion(int monto);
        public int Extraccion(int monto, TipoExtraccion tipo);
    }
}
