using System.Threading.Tasks;

namespace YonahChat.WPF.Modules.YonahMain.Data
{
    public interface IChatListDataService
    {
        Task<> GetByIdAsync(int chatId);
    }
}
