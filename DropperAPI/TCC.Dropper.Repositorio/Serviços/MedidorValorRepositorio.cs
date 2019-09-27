using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Dropper.Repositorio.Interfaces;

namespace TCC.Dropper.Repositorio.Serviços
{
    public class MedidorValorRepositorio : IMedidorValorRepositorio
    {
        public IEnumerable<MedidorVazao> ListarTodosOsSensores()
        {
            using (DropperEntities entities = new DropperEntities())
            {
                return entities.MedidorVazao.ToList();
            }
        }
    }
}
