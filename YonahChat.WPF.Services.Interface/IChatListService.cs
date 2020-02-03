using System;
using System.Collections.Generic;
using YonahChat.WPF.Business;

namespace YonahChat.WPF.Services.Interface
{
    public interface IChatListService
    {
        IEnumerable<ChatEntry> GetChatListByIdAsync(int userId);
    }
}
