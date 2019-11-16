using TCC.Dropper.Dom.Modelos;
using System;
using System.Collections.Generic;

namespace Dropper.Negocio.Interfaces
{
    public interface IVazaoNegocio
    {
        IEnumerable<VazaoModelo> listAllFlowMeasurement();
        IEnumerable<VazaoModelo> listFlowMeasurementByFilter(FiltroVazaoModelo filtro);
        VazaoModelo cadastrarValorMedicao(VazaoModelo p_VazaoModelo);
        void InserirValores();
    }
}
