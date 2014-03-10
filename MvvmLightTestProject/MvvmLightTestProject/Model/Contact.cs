using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace MvvmLightTestProject.Model
{
    public class Contact
    {

        public static void AddContactExecute()
        {

        }

        public ICommand EditContact { get; set; }

        private void EditContactExecute()
        {
        }

        public string Name { get; set; }
        public string Email { get; set; }

        public Contact()
        {
            EditContact = new RelayCommand(EditContactExecute, () => true);
        }
    }
}
