using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Dropper.Repositorio.Interfaces;

namespace TCC.Dropper.Repositorio.Serviços
{
    public class SensorRepositorio : ISensorRepositorio
    {
        public IEnumerable<SENSOR> ListarTodosOsSensores()
        {
            using (DB_DropperEntities entities = new DB_DropperEntities())
            {
                return entities.SENSOR.ToList();
            }
        }
    }
}
