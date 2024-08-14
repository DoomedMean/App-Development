namespace App.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void Login_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("ERROR", "NOT CONFIGURED YET", "OK");
    }
}