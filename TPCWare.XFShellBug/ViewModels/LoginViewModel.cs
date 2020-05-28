using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace TPCWare.XFShellBug.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand ChangeAuthenticationStateCommand { get; set; }

        public string PageTitle => !((App)Application.Current).IsUserLogged ? "Login" : "Logout";

        public string UserStatus => ((App)Application.Current).IsUserLogged ? "User is logged" : "User is not logged";

        public string ButtonText => PageTitle;

        public LoginViewModel()
        {
            ChangeAuthenticationStateCommand = new Command(ChangeAuthenticationState);
        }

        private void ChangeAuthenticationState()
        {
            ((App)Application.Current).IsUserLogged = !((App)Application.Current).IsUserLogged;

            OnPropertyChanged(nameof(PageTitle));
            OnPropertyChanged(nameof(UserStatus));
            OnPropertyChanged(nameof(ButtonText));
        }
    }
}
