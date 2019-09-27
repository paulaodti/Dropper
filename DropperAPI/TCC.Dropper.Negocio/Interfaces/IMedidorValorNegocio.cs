using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Dropper.Dom.Modelos;

namespace TCC.Dropper.Negocio.Interfaces
{
    public interface IMedidorValorNegocio
    {
        IEnumerable<MedidorVazaoModelo> ListarTodosOsSensores();
    }
}
