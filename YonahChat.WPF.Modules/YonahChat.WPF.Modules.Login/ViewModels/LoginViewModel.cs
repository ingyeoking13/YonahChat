using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using YonahChat.WPF.Core.EventAggregator;

namespace YonahChat.WPF.Modules.Login.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private string _message;
        private readonly EventAggregator ea;
        private DelegateCommand _LoginBtnClick;
        public DelegateCommand CLoginBtnClick =>
            _LoginBtnClick ?? (_LoginBtnClick = new DelegateCommand(OnLoginBtnClick));

        void OnLoginBtnClick()
        {
            ea.GetEvent<GoToYonahMain>().Publish();
        }

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public LoginViewModel(EventAggregator ea)
        {
            Message = "View A from your Prism Module";
            this.ea = ea;
        }

    }
}
