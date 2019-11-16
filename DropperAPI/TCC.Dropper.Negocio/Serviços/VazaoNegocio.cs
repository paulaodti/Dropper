using TCC.Dropper.Dom.Modelos;
using TCC.Dropper.Dom.Enumerables;
using Dropper.Negocio.Interfaces;
using System;
using System.Linq;
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

        public VazaoModelo cadastrarValorMedicao(VazaoModelo p_VazaoModelo)
        {
            VazaoModelo v_VazaoModelo = new VazaoModelo();
            AutoMapper.Mapper.Map(m_IVazaoRepositorio.cadastrarValorModelo(p_VazaoModelo), v_VazaoModelo);
            return v_VazaoModelo;
        }

        public IEnumerable<VazaoModelo> listFlowMeasurementByFilter(FiltroVazaoModelo filtro)
        {
            validarFiltro(filtro);
            /*obterDatasPorPeriodo(filtro);*/
            IEnumerable<VazaoModelo> v_FlowMeasurements = new List<VazaoModelo>();
            AutoMapper.Mapper.Map(m_IVazaoRepositorio.listarTodosVazaoByFilter(filtro), v_FlowMeasurements);
            return v_FlowMeasurements;
        }

        public void InserirValores()
        {
            throw new NotImplementedException();
        }
        protected void validarFiltro(FiltroVazaoModelo filtro)
        {
            if (filtro.dataInicial == null && filtro.dataFinal == null && filtro.idSensor == null && filtro.periodo == null)
            {
                throw new Exception("Deve haver pelo menos um filtro");
            }
        }

        private void obterDatasPorPeriodo(FiltroVazaoModelo filtro)
        {
            DateTime dataIni = DateTime.Now;
            DateTime dataFin = DateTime.Now;
            if (PeriodoEnum.UltimaHora.GetHashCode() == filtro.periodo)
            {
                dataIni = dataIni.AddHours(-1);
            }
            else if (PeriodoEnum.Diario.GetHashCode() == filtro.periodo)
            {
                TimeSpan horaAtual = dataIni.TimeOfDay;
                dataIni = dataIni.Add(-horaAtual);
            }
            else if (PeriodoEnum.Semanal.GetHashCode() == filtro.periodo)
            {
                TimeSpan horaAtual = dataIni.TimeOfDay;
                int diaDaSemana = dataIni.DayOfWeek.GetHashCode();
                dataIni = dataIni.AddDays(-diaDaSemana);
                dataIni = dataIni.Add(-horaAtual);
            }
            else if (PeriodoEnum.Mensal.GetHashCode() == filtro.periodo)
            {
                TimeSpan horaAtual = dataIni.TimeOfDay;
                int diaDoMes = dataIni.Day - 1;
                dataIni = dataIni.AddDays(-diaDoMes);
                dataIni = dataIni.Add(-horaAtual);
            }
            filtro.dataInicial = dataIni;
            filtro.dataFinal = dataFin;
        }
    }
}
