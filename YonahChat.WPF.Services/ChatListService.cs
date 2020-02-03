using System.Collections.Generic;
using YonahChat.WPF.Business;

namespace YonahChat.WPF.Services
{
    public class ChatListServices
    {
        public IEnumerable<ChatEntry> GetChatListByIdAsync(int userId)
        {
            return new List<ChatEntry>();
        }
    }
}
