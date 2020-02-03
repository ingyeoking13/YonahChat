using System.Windows.Controls;
using YonahChat.WPF.Services.Interface;

namespace YonahChat.WPF.Modules.YonahMain.Menus
{
    public partial class ChatListTab : UserControl
    {
        private readonly IChatListService _chatListDataService;
        public ChatListTab(IChatListService chatListDataService)
        {
            InitializeComponent();
            _chatListDataService = chatListDataService;

        }
    }
}
