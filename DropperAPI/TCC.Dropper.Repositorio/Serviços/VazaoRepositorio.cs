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

        public IEnumerable<VAZAO> listarTodosVazaoByDate(DateTime p_InicialDate, DateTime p_FinalDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VAZAO> listarTodosVazaoBySensorID(int p_SensorID)
        {
            throw new NotImplementedException();
        }
    }
}
