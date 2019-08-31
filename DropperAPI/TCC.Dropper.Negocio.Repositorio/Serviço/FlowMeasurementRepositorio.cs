using System.Collections.Generic;
using System.Linq;
using DropperRepositorio.Interface;

namespace DropperRepositorio.Serviço
{
    public class FlowMeasurementRepositorio : IFlowMeasurementRepositorio
    {
        public IEnumerable<FLOW_MEASUREMENT> listAllFlowMeasurement()
        {
            using (DropperEntities entities = new DropperEntities())
            {
                 var v_FlowMeasurement = entities.FLOW_MEASUREMENT.ToList();
                return v_FlowMeasurement;
            }
        }

        public IEnumerable<FLOW_MEASUREMENT> listBySensorId(int p_SensorID)
        {
            using (DropperEntities entities = new DropperEntities())
            {
                return entities.FLOW_MEASUREMENT.Where(measurement => measurement.ID_FLOW_SENSOR == p_SensorID);
            }
        }
    }
}
