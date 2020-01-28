using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using YonahChat.WPF.Core;
using YonahChat.WPF.Core.EventAggregator;
using YonahChat.WPF.Modules.Login.Views;
using YonahChat.WPF.Modules.YonahMain.Views;

namespace YonahChat.WPF.Main.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        private readonly IRegionManager regionManager;
        private readonly IEventAggregator ea;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        void OnChange()
        {
            //this.regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(YonahMainView));
            this.regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(YonahMainView));
        }

        public MainWindowViewModel(IRegionManager regionManager, IEventAggregator ea)
        {
            this.regionManager = regionManager;
            this.ea = ea;

            this.ea.GetEvent<GoToYonahMain>().Subscribe(OnChange, ThreadOption.PublisherThread);
        }
    }
}
