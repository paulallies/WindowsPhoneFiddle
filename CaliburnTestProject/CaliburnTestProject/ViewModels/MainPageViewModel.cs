using System.Windows;
using Caliburn.Micro;

namespace CaliburnTestProject.ViewModels
{
    public class MainPageViewModel : PropertyChangedBase
    {

        private readonly INavigationService navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            Name = "Paul";

        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public void ShowAlert()
        {
            MessageBox.Show(Name);
        }

        public void NavigateTo()
        {
            navigationService.UriFor<SecondPageViewModel>().Navigate();
        }
    }
}
