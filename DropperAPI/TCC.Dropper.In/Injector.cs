using Unity;
using Dropper.Negocio.Interfaces;
using Dropper.Negocio.Serviços;
using TCC.Dropper.Repositorio.Interfaces;
using TCC.Dropper.Repositorio.Serviços;

namespace TCC.Dropper.In
{
    public static class Injetor
    {
        public static IUnityContainer ConstrutorContainer;

        public static void Inicializar(IUnityContainer container)
        {
            ConstrutorContainer = container;
            ConfigurarInjecoesNegocio();
            ConfigurarInjecoesRepositorio();
        }

        private static void ConfigurarInjecoesRepositorio()
        {
            ConstrutorContainer.RegisterType<IMedicaoValorRepositorio, MedicaoValorRepositorio>();
        }

        private static void ConfigurarInjecoesNegocio()
        {
            ConstrutorContainer.RegisterType<IMedicaoValorNegocio, MedicaoValorNegocio>();
        }
    }
}
