using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace File_Store.Models
{
    public class User : INotifyPropertyChanged
    {
        public string username { get; set; }
        public string password { get; set; }
        public string auth { get; set; }
        public string storageurl { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler) { 
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
               
    }
}
