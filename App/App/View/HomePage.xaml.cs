namespace App.View;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        var Detail = new DetailPage();
        BindingContext = Detail;
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is int Itemid) // sent ID to other page
        {
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}/{nameof(DetailPage)}?Id={Itemid}");
        }
    }

    private void Search_Completed(object sender, EventArgs e)
    {
        DisplayAlert("ERROR", "NOT CONFIGURED", "OK");
    }
}