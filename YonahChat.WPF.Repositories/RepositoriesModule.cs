using Prism.Ioc;
using Prism.Modularity;

namespace YonahChat.WPF.Repositories
{
    public class RepositoriesModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IYonahChatRepository, YonahChatRepositoryTest>();
        }
    }
}