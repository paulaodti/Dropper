using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Dropper.Dom.Modelos
{
    public class MedicaoValorModelo
    {
        public int CodMedidorVazao { get; set; }
        public int CodMedicaoVazaoValor { get; set; }
        public DateTime DataMedicaoVazaoValor { get; set; }
        public double Valor { get; set; }
    }
}
