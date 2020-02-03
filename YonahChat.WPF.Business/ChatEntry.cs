using System;
using System.Collections.ObjectModel;

namespace YonahChat.WPF.Business
{
    public class ChatEntry : BusinessBase
    {
        public int Id { get; set; }

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
    }
}
