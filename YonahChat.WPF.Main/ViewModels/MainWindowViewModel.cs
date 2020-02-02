using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using YonahChat.WPF.Core;
using YonahChat.WPF.Core.EventAggregator;
using YonahChat.WPF.Modules.YonahMain.Views;

namespace YonahChat.WPF.Main.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        private readonly IRegionManager _regionManager;
        private readonly IEventAggregator _ea;
        private DelegateCommand<string> _navigateCommand;
        public DelegateCommand<string> NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(ExecuteNavigateCommand));

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        void OnChange()
        {
            _regionManager.RequestNavigate(RegionNames.RootContentRegion, nameof(YonahMainView));
        }

        public MainWindowViewModel(IRegionManager regionManager, IEventAggregator ea)
        {
            _regionManager = regionManager;
            _ea = ea;
            _ea.GetEvent<GoToYonahMain>().Subscribe(OnChange, ThreadOption.PublisherThread);
        }

        void ExecuteNavigateCommand(string navigationPath)
        {
            if (string.IsNullOrEmpty(navigationPath))
                throw new ArgumentNullException();

            _regionManager.RequestNavigate(RegionNames.RootContentRegion, navigationPath);
        }
    }
}
