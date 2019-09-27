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
    public class MedidorValorNegocio : IMedidorValorNegocio
    {
        MedidorValorRepositorio medidorValorRepositorio;
        public MedidorValorNegocio(MedidorValorRepositorio medidorValorRepositorio)
        {
            this.medidorValorRepositorio = medidorValorRepositorio;
        }
        public IEnumerable<MedidorVazaoModelo> ListarTodosOsSensores()
        {
            IEnumerable<MedidorVazaoModelo> medidorVazaoModelos = new List<MedidorVazaoModelo>();
            AutoMapper.Mapper.Map(this.medidorValorRepositorio.ListarTodosOsSensores(), medidorVazaoModelos);
            return medidorVazaoModelos;

        }
    }
}
