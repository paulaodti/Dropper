using Dropper.Dom.Models;
using System;
using System.Collections.Generic;

namespace Dropper.Negocio.Interfaces
{
    public interface IFlowMeasurementNegocio
    {
        IEnumerable<FlowMeasurementModel> listAllFlowMeasurement();
        IEnumerable<FlowMeasurementModel> listFlowMeasurementBySensorID(int p_SensorID);
        IEnumerable<FlowMeasurementModel> listFlowMeasurementByDate(DateTime p_InicialDate, DateTime p_FinalDate);
    }
}
