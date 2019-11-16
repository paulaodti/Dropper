using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Dropper.Dom.Modelos;
using TCC.Dropper.Negocio.Interfaces;
using TCC.Dropper.Repositorio.Serviços;

namespace TCC.Dropper.Negocio.Serviços
{
    public class SensorNegocio : ISensorNegocio
    {
        SensorRepositorio sensorRepositorio;
        public SensorNegocio(SensorRepositorio sensorRepositorio)
        {
            this.sensorRepositorio = sensorRepositorio;
        }
        public IEnumerable<SensorModelo> ListarTodosOsSensores()
        {
            IEnumerable<SensorModelo> medidorVazaoModelos = new List<SensorModelo>();
            AutoMapper.Mapper.Map(this.sensorRepositorio.ListarTodosOsSensores(), medidorVazaoModelos);
            return medidorVazaoModelos;

        }

        public SensorModelo EditarSensor(int id, SensorModelo sensor)
        {
            SensorModelo medidorVazaoModelo = new SensorModelo();
            AutoMapper.Mapper.Map(this.sensorRepositorio.EditarSensor(id,sensor.DESCRICAO, sensor.ENTRADA_GLOBAL), medidorVazaoModelo);
            return medidorVazaoModelo;
        }
    }
}
