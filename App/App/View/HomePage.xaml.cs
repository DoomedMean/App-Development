namespace App.View;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}/{nameof(DetailPage)}");
    }

    private void Search_Completed(object sender, EventArgs e)
    {
        DisplayAlert("ERROR", "NOT CONFIGURED", "OK");
    }
}