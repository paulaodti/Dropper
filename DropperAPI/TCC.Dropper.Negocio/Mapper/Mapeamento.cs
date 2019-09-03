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
            CreateMap<MedicaoValorModelo,MedicaoValor>();
            CreateMap<MedicaoValor, MedicaoValorModelo>();
        }
    }
}
