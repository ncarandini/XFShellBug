using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TPCWare.XFShellBug.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}