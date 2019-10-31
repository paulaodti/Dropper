using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Dropper.Repositorio.Interfaces
{
   public interface ISensorRepositorio
    {
        IEnumerable<SENSOR> ListarTodosOsSensores();
    }
}
