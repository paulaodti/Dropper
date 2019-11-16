using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Dropper.Dom.Modelos
{
    public class FiltroVazaoModelo
    {
        public DateTime? dataInicial { get; set; }
        public DateTime? dataFinal { get; set; }
        public int? idSensor { get; set; }
        public int periodo { get; set; }
    }
}
