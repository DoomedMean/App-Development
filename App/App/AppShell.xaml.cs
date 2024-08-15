using App.Model;
using App.View;
//using Windows.Networking.BackgroundTransfer;

namespace App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AccountPage), typeof(AccountPage));
            Routing.RegisterRoute($"//{nameof(AccountPage)}/{nameof(ChangePasswordPage)}", typeof(ChangePasswordPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute($"//{nameof(HomePage)}/{nameof(DetailPage)}", typeof(DetailPage));  
        }
    }
}
