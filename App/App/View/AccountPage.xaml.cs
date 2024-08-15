using System.Diagnostics;

namespace App.View;

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
		InitializeComponent();
	}

    private async void LogOut_Button(object sender, EventArgs e)
    {
        string action = await DisplayActionSheet("Log Out", "OK", "Cancel", "Are you want to Log Out?");
        switch (action){
            case "OK":
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
                break;
            case "Cancel":
            break;
        }
    }

    private async void ChangePassword_Button(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//AccountPage/ChangePasswordPage");
    }
}