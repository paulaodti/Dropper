using TCC.Dropper.Dom.Modelos;
using System;
using System.Collections.Generic;

namespace Dropper.Negocio.Interfaces
{
    public interface IVazaoNegocio
    {
        IEnumerable<VazaoModelo> listAllFlowMeasurement();
        IEnumerable<VazaoModelo> listFlowMeasurementBySensorID(int p_SensorID);
        IEnumerable<VazaoModelo> listFlowMeasurementByDate(DateTime p_InicialDate, DateTime p_FinalDate);
        VazaoModelo cadastrarValorMedicao(VazaoModelo p_VazaoModelo);
    }
}
