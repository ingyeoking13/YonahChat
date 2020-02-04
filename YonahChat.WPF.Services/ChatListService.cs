using System.Collections.Generic;
using YonahChat.WPF.Business;
using YonahChat.WPF.Services.Interface;

namespace YonahChat.WPF.Services
{
    public class ChatListServices : IChatListService
    {
        public IEnumerable<ChatEntry> GetChatListByIdAsync(int userId)
        {
            if (userId != 1) return new List<ChatEntry>();

            return new List<ChatEntry>
            {
                new ChatEntry("HI"),
                new ChatEntry("BYE"),
                new ChatEntry("NIGHT"),
                new ChatEntry("DAY")
            };
        }
    }
}
