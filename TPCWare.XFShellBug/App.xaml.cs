using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPCWare.XFShellBug
{
    public partial class App : Application
    {
        public event EventHandler AuthenticationStateChanged;

        private bool isUserLogged;
        public bool IsUserLogged
        {
            get => isUserLogged;
            set
            {
                if(isUserLogged != value)
                {
                    isUserLogged = value;
                    AuthenticationStateChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
