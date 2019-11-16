using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Dropper.Dom.Modelos;

namespace TCC.Dropper.Repositorio.Interfaces
{
    public interface IVazaoRepositorio
    {
        IEnumerable<VAZAO> listarTodosVazao();
        IEnumerable<VAZAO> listarTodosVazaoByFilter(FiltroVazaoModelo filtro);
        VAZAO cadastrarValorModelo(VazaoModelo p_VazaoModelo);
    }
}
