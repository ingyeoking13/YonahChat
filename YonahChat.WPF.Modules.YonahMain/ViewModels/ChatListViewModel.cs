using Prism.Mvvm;
using System.Collections.ObjectModel;
using YonahChat.WPF.Business;
using YonahChat.WPF.Services.Interface;

namespace YonahChat.WPF.Modules.YonahMain.ViewModels
{
    public class ChatListViewModel : BindableBase
    {
        private readonly IChatListService _chatListService;
        private ObservableCollection<string> _chatTitles = new ObservableCollection<string>();
        public ObservableCollection<string> ChatTitles
        {
            get { return _chatTitles; }
            set { SetProperty(ref _chatTitles, value); }
        }
        public ChatListViewModel(IChatListService chatListService)
        {
            _chatListService = chatListService;
            var chatList = _chatListService.GetChatListByIdAsync(1);

            foreach(ChatEntry chatEntry in chatList)
                ChatTitles.Add(chatEntry.ChatTitle);
        }
    }
}
