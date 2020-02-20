namespace YonahChat.WPF.Business.Users
{
    public class User : BusinessBase
    {
        // ID Can not
        public int id { get; }
        private string _userName { get; set; }

        private string _nickName;
        public string NickName
        {
            get { return _nickName; }
            set { SetProperty(ref _nickName, value); }
        }
    }
}
