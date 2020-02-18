using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using YonahChat.WPF.Core;
using YonahChat.WPF.Modules.YonahMain.Menus;
using YonahChat.WPF.Modules.YonahMain.ViewModels;
using YonahChat.WPF.Repositories;
using YonahChat.WPF.Services;
using YonahChat.WPF.Services.Interface;

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
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IYonahChatRepository, YonahChatRepositoryTest>();
            containerRegistry.Register<IChatListService, ChatListServices>();
            ViewModelLocationProvider.Register<ChatListTab, ChatListViewModel>();
        }
    }
}