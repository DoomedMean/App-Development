namespace App.View;

public partial class ChangePasswordPage : ContentPage
{
	public ChangePasswordPage()
	{
		InitializeComponent();
	}

    private void Save_Button(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync($"//{nameof(AccountPage)}");
    }
}