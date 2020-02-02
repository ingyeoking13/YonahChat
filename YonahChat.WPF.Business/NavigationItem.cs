using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace YonahChat.WPF.Business
{
    public class NavigationItem
    {
        public string Caption { get; set; }
        public string NavigationPath { get; set; }
        /// <summary>
        /// <see cref="NavigationItem"/> can have multiple <see cref="NavigationItem"/> inside it. 
        /// </summary>
        public ObservableCollection<NavigationItem> Items { get; set; }
    }
}
