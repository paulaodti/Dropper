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

        public SENSOR EditarSensor(int id, string descricao, bool entradaGlobal)
        {
            using (DB_DropperEntities entities = new DB_DropperEntities())
            {
                SENSOR sensorbanco = entities.SENSOR.Where(sensor => sensor.ID_SENSOR == id).FirstOrDefault();
                if (sensorbanco == null)
                {
                    throw new KeyNotFoundException("Sensor não encontrado");
                }
                sensorbanco.DESCRICAO = descricao;
                sensorbanco.ENTRADA_GLOBAL = entradaGlobal;
                entities.SaveChanges();
                return sensorbanco;
            }
        }
    }
}
