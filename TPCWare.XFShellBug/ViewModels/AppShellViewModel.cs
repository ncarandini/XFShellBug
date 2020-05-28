using System;
using Xamarin.Forms;

namespace TPCWare.XFShellBug.ViewModels
{
    public class AppShellViewModel : BaseViewModel
    {
        public string LogInOutTitle => !((App)Application.Current).IsUserLogged ? "Login" : "Logout";
        public string LogInOutIconName => !((App)Application.Current).IsUserLogged ? "tab_login.png" : "tab_logout.png";

        public AppShellViewModel()
        {
            ((App)Application.Current).AuthenticationStateChanged += OnAuthenticationStateChanged;
        }

        private void OnAuthenticationStateChanged(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(LogInOutTitle));
            OnPropertyChanged(nameof(LogInOutIconName));
        }
    }
}