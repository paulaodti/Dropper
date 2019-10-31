using AutoMapper;
using TCC.Dropper.Dom.Modelos;
using TCC.Dropper.Repositorio;

namespace Dropper.Dom.Mapeamento
{
    public class Mapeamento : Profile
    {
        public static void Run()
        {
            AutoMapper.Mapper.Initialize(mapper =>
            {
                mapper.AddProfile<Mapeamento>();
            });
        }
        public Mapeamento()
        {
            CreateMap<VAZAO,VazaoModelo>();
            CreateMap<VazaoModelo, VAZAO>();
            CreateMap<SENSOR, SensorModelo>();
            CreateMap<SensorModelo, SENSOR>();
        }
    }
}
