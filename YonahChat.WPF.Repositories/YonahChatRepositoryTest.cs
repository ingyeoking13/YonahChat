using System.Collections.Generic;
using YonahChat.WPF.Business;

namespace YonahChat.WPF.Repositories
{
    public class YonahChatRepositoryTest : IYonahChatRepository
    {
        public List<ChatEntry> GetChatentryWithUserID(int id)
        {
            return new List<ChatEntry> {
                new ChatEntry("HI, This Is First Chat Room"),
                new ChatEntry("Good Night ..."),
                new ChatEntry("Dude, This Room so funny."),
                new ChatEntry("HAHAHA")
            };
        }
    }
}