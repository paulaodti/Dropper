using TCC.Dropper.Dom.Modelos;
using System;
using System.Collections.Generic;

namespace Dropper.Negocio.Interfaces
{
    public interface IMedicaoValorNegocio
    {
        IEnumerable<MedicaoValorModelo> listAllFlowMeasurement();
        IEnumerable<MedicaoValorModelo> listFlowMeasurementBySensorID(int p_SensorID);
        IEnumerable<MedicaoValorModelo> listFlowMeasurementByDate(DateTime p_InicialDate, DateTime p_FinalDate);
        MedicaoValorModelo cadastrarValorMedicao(MedicaoValorModelo p_MedicaoValorModelo);
    }
}
