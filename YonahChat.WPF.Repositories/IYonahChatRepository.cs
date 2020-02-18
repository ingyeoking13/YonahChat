using System.Collections.Generic;
using YonahChat.WPF.Business;

namespace YonahChat.WPF.Repositories
{
    public interface IYonahChatRepository
    {
        List<ChatEntry> GetChatentryWithUserID(int id);
    }
}