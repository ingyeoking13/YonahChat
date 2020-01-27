using Prism.Mvvm;

namespace YonahChat.WPF.Modules.Login.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public LoginViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}
