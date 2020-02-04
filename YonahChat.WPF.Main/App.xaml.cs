using YonahChat.WPF.Main.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using YonahChat.WPF.Modules.Login;
using Prism.Events;
using YonahChat.WPF.Modules.YonahMain.Views;
using YonahChat.WPF.Modules.YonahMain;

namespace YonahChat.WPF.Main
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<EventAggregator>();
            containerRegistry.RegisterForNavigation<YonahMainView>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<LoginModule>();
            moduleCatalog.AddModule<YonahMainModule>();
        }
    }
}
