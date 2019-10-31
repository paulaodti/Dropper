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
        IEnumerable<VAZAO> listarTodosVazaoBySensorID(int p_SensorID);
        IEnumerable<VAZAO> listarTodosVazaoByDate(DateTime p_InicialDate, DateTime p_FinalDate);
        VAZAO cadastrarValorModelo(VazaoModelo p_VazaoModelo);
    }
}
