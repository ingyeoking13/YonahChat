using System;
using System.Collections.ObjectModel;

namespace YonahChat.WPF.Business
{
    public class ChatEntry : BusinessBase
    {
        private static uint latestId = 0;
        public uint Id { get; }

        private string _chatTitle;
        public string ChatTitle
        {
            get { return _chatTitle; }
            set { SetProperty(ref _chatTitle, value); }
        }

        private DateTime _createdTime;
        public DateTime CreatedTime
        {
            get { return _createdTime; }
            set { SetProperty(ref _createdTime, value); }
        }

        private ObservableCollection<string> _chatMessages;
        public ObservableCollection<string> ChatMessages
        {
            get { return _chatMessages; }
            set { SetProperty(ref _chatMessages, value); }
        }

        public ChatEntry()
        {
            Id = ++latestId;
            ChatTitle = "Hello";
            CreatedTime = DateTime.UtcNow;
            ChatMessages = new ObservableCollection<string>();  
        }

        public ChatEntry(string chatTitle)
        {
            Id = ++latestId;
            ChatTitle = chatTitle;
            CreatedTime = DateTime.UtcNow;
            ChatMessages = new ObservableCollection<string>();  
        }
    }
}
