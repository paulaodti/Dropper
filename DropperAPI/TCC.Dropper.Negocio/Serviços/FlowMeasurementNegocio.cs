using Dropper.Dom.Models;
using Dropper.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropperRepositorio.Interface;

namespace Dropper.Negocio.Serviços
{
    public class FlowMeasurementNegocio : IFlowMeasurementNegocio
    {
        private IFlowMeasurementRepositorio m_IFlowMeasurementRepositorio;

        public FlowMeasurementNegocio(IFlowMeasurementRepositorio p_IFlowMeasurementRepositorio)
        {
            m_IFlowMeasurementRepositorio = p_IFlowMeasurementRepositorio;
        }
        public IEnumerable<FlowMeasurementModel> listAllFlowMeasurement()
        {
            IEnumerable<FlowMeasurementModel> v_FlowMeasurements = new List<FlowMeasurementModel>();
            var x = m_IFlowMeasurementRepositorio.listAllFlowMeasurement();
            AutoMapper.Mapper.Map(m_IFlowMeasurementRepositorio.listAllFlowMeasurement(), v_FlowMeasurements);
            return v_FlowMeasurements;
        }

        public IEnumerable<FlowMeasurementModel> listFlowMeasurementByDate(DateTime p_InicialDate, DateTime p_FinalDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FlowMeasurementModel> listFlowMeasurementBySensorID(int p_SensorID)
        {
            throw new NotImplementedException();
        }
    }
}
