using ADPlayer.Module.Main.Views;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ADPlayer.Module.Main
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            containerProvider.Resolve<IRegionManager>();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainContainerView>();
        }
    }
}
