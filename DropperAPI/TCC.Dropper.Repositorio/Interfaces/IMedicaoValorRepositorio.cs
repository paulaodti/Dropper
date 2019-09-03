using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Dropper.Dom.Modelos;

namespace TCC.Dropper.Repositorio.Interfaces
{
    public interface IMedicaoValorRepositorio
    {
        IEnumerable<MedicaoValor> listarTodosMedicaoValor();
        IEnumerable<MedicaoValor> listarTodosMedicaoValorBySensorID(int p_SensorID);
        IEnumerable<MedicaoValor> listarTodosMedicaoValorByDate(DateTime p_InicialDate, DateTime p_FinalDate);
        MedicaoValor cadastrarValorModelo(MedicaoValorModelo p_MedicaoValorModelo);
    }
}
