using System.Collections.Generic;
using YonahChat.WPF.Business;
using YonahChat.WPF.Repositories;
using YonahChat.WPF.Services.Interface;

namespace YonahChat.WPF.Services
{
    public class ChatListServices : IChatListService
    {
        private readonly IYonahChatRepository _repository;

        public IEnumerable<ChatEntry> GetChatListByIdAsync(int userId)
        {
            if (userId != 1) return new List<ChatEntry>();

            return _repository.GetChatentryWithUserID(userId);
        }
        public ChatListServices(IYonahChatRepository repository)
        {
            _repository = repository;
        }
    }
}
