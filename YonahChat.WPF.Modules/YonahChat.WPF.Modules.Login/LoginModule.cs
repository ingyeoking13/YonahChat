using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using YonahChat.WPF.Core;
using YonahChat.WPF.Modules.Login.Views;

namespace YonahChat.WPF.Modules.Login
{
    public class LoginModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public LoginModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.RootContentRegion, typeof(LoginView));
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}