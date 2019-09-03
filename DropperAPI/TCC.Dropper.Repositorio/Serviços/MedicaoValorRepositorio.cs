using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Dropper.Dom.Modelos;
using TCC.Dropper.Repositorio.Interfaces;

namespace TCC.Dropper.Repositorio.Serviços
{
    public class MedicaoValorRepositorio : IMedicaoValorRepositorio
    {
        public MedicaoValor cadastrarValorModelo(MedicaoValorModelo p_MedicaoValorModelo)
        {
            using (DropperEntities v_Entities = new DropperEntities())
            {
                MedicaoValor v_MedicaoValor = new MedicaoValor();
                v_MedicaoValor.CodMedidorVazao = p_MedicaoValorModelo.CodMedidorVazao;
                v_MedicaoValor.DataMedicaoVazaoValor = p_MedicaoValorModelo.DataMedicaoVazaoValor;
                v_MedicaoValor.Valor = p_MedicaoValorModelo.Valor;
                v_Entities.MedicaoValors.Add(v_MedicaoValor);
                v_Entities.SaveChanges();
                return v_MedicaoValor;
            }
        }

        public IEnumerable<MedicaoValor> listarTodosMedicaoValor()
        {
            using (DropperEntities v_Entities = new DropperEntities())
            {
                return v_Entities.MedicaoValors.ToList();
            }
        }

        public IEnumerable<MedicaoValor> listarTodosMedicaoValorByDate(DateTime p_InicialDate, DateTime p_FinalDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MedicaoValor> listarTodosMedicaoValorBySensorID(int p_SensorID)
        {
            throw new NotImplementedException();
        }
    }
}
