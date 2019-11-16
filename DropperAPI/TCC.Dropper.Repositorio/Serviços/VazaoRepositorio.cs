using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Dropper.Dom.Modelos;
using TCC.Dropper.Repositorio.Interfaces;

namespace TCC.Dropper.Repositorio.Serviços
{
    public class VazaoRepositorio : IVazaoRepositorio
    {
        public VAZAO cadastrarValorModelo(VazaoModelo p_VazaoModelo)
        {
            using (DB_DropperEntities v_Entities = new DB_DropperEntities())
            {
                VAZAO v_Vazao = new VAZAO();
                v_Vazao.ID_SENSOR = p_VazaoModelo.ID_SENSOR;
                v_Vazao.DT_MEDICAO = p_VazaoModelo.DT_MEDICAO;
                v_Vazao.VALOR = p_VazaoModelo.VALOR;
                v_Entities.VAZAO.Add(v_Vazao);
                v_Entities.SaveChanges();
                return v_Vazao;
            }
        }

        public IEnumerable<VAZAO> listarTodosVazao()
        {
            using (DB_DropperEntities v_Entities = new DB_DropperEntities())
            {
                return v_Entities.VAZAO.ToList();
            }
        }

        public IEnumerable<VAZAO> listarTodosVazaoByFilter(FiltroVazaoModelo filtro)
        {
            
            using (DB_DropperEntities v_Entities = new DB_DropperEntities())
            {
                IEnumerable<VAZAO> listaFiltrada = new List<VAZAO>();
                listaFiltrada = v_Entities.VAZAO;
                if (filtro.dataInicial != null)
                {
                    listaFiltrada = listaFiltrada.Where(vazao => vazao.DT_MEDICAO.CompareTo(filtro.dataInicial) >= 0);
                }
                if (filtro.dataFinal != null)
                {
                    listaFiltrada = listaFiltrada.Where(vazao => vazao.DT_MEDICAO.CompareTo(filtro.dataFinal) <= 0);
                }
                if (filtro.idSensor != null)
                {
                    listaFiltrada = listaFiltrada.Where(vazao => vazao.ID_SENSOR == filtro.idSensor);
                }
                return listaFiltrada.ToList();
            }
        }
    }
}
