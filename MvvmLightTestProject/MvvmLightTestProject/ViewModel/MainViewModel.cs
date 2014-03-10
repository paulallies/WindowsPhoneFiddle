using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmLightTestProject.Model;

namespace MvvmLightTestProject.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public ICommand AddContact { get; private set; }

        public List<Contact> ContactList { get; set; }
        
        public MainViewModel()
        {
            IDataService dataService = new DataService();
            AddContact = new RelayCommand(Contact.AddContactExecute, () => true);
            ContactList = dataService.GetContacts();
        }


    }
}