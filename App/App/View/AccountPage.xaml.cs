using System.Diagnostics;

namespace App.View;

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
		InitializeComponent();
	}

    private void LogOut_Button(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }

    private async void ChangePassword_Button(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//AccountPage/ChangePasswordPage");
        //Debug.WriteLine(Shell.Current.CurrentState?.Location.OriginalString);
    }
}