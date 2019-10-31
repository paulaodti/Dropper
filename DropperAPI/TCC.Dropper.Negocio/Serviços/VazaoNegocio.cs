using TCC.Dropper.Dom.Modelos;
using Dropper.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using TCC.Dropper.Repositorio.Interfaces;

namespace Dropper.Negocio.Serviços
{
    public class VazaoNegocio : IVazaoNegocio
    {
        private IVazaoRepositorio m_IVazaoRepositorio;

        public VazaoNegocio(IVazaoRepositorio p_IVazaoRepositorio)
        {
            m_IVazaoRepositorio = p_IVazaoRepositorio;
        }
        public IEnumerable<VazaoModelo> listAllFlowMeasurement()
        {
            IEnumerable<VazaoModelo> v_FlowMeasurements = new List<VazaoModelo>();
            AutoMapper.Mapper.Map(m_IVazaoRepositorio.listarTodosVazao(), v_FlowMeasurements);
            return v_FlowMeasurements;
        }

        public IEnumerable<VazaoModelo> listFlowMeasurementByDate(DateTime p_InicialDate, DateTime p_FinalDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VazaoModelo> listFlowMeasurementBySensorID(int p_SensorID)
        {
            throw new NotImplementedException();
        }

        public VazaoModelo cadastrarValorMedicao(VazaoModelo p_VazaoModelo)
        {
            VazaoModelo v_VazaoModelo = new VazaoModelo();
            AutoMapper.Mapper.Map(m_IVazaoRepositorio.cadastrarValorModelo(p_VazaoModelo), v_VazaoModelo);
            return v_VazaoModelo;
        }
    }
}
