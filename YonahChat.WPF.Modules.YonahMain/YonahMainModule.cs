using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using YonahChat.WPF.Core;
using YonahChat.WPF.Modules.YonahMain.Menus;

namespace YonahChat.WPF.Modules.YonahMain
{
    public class YonahMainModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public YonahMainModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ChatListRegion, typeof(ChatListTab));
            //_regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof());
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}