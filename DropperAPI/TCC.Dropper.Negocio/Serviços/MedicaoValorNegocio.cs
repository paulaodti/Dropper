using TCC.Dropper.Dom.Modelos;
using Dropper.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using TCC.Dropper.Repositorio.Interfaces;

namespace Dropper.Negocio.Serviços
{
    public class MedicaoValorNegocio : IMedicaoValorNegocio
    {
        private IMedicaoValorRepositorio m_IMedicaoValorRepositorio;

        public MedicaoValorNegocio(IMedicaoValorRepositorio p_IMedicaoValorRepositorio)
        {
            m_IMedicaoValorRepositorio = p_IMedicaoValorRepositorio;
        }
        public IEnumerable<MedicaoValorModelo> listAllFlowMeasurement()
        {
            IEnumerable<MedicaoValorModelo> v_FlowMeasurements = new List<MedicaoValorModelo>();
            AutoMapper.Mapper.Map(m_IMedicaoValorRepositorio.listarTodosMedicaoValor(), v_FlowMeasurements);
            return v_FlowMeasurements;
        }

        public IEnumerable<MedicaoValorModelo> listFlowMeasurementByDate(DateTime p_InicialDate, DateTime p_FinalDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MedicaoValorModelo> listFlowMeasurementBySensorID(int p_SensorID)
        {
            throw new NotImplementedException();
        }

        public MedicaoValorModelo cadastrarValorMedicao(MedicaoValorModelo p_MedicaoValorModelo)
        {
            MedicaoValorModelo v_MedicaoValorModelo = new MedicaoValorModelo();
            AutoMapper.Mapper.Map(m_IMedicaoValorRepositorio.cadastrarValorModelo(p_MedicaoValorModelo), v_MedicaoValorModelo);
            return v_MedicaoValorModelo;
        }
    }
}
