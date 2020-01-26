using YonahChat.WPF.Main.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using YonahChat.WPF.Modules.Login;

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

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<LoginModule>();
        }
    }
}
