using Prism.Mvvm;

namespace YonahChat.WPF.Modules.YonahMain.ViewModels
{
    public class YonahMainViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public YonahMainViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}
