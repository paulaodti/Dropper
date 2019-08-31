using AutoMapper;
using Dropper.Dom.Models;
using DropperRepositorio;

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
            CreateMap<FlowMeasurementModel,FLOW_MEASUREMENT>();
            CreateMap<FLOW_MEASUREMENT, FlowMeasurementModel>();
        }
    }
}
