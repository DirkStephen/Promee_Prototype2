namespace Promee_Prototype2.Promee_Settings;

public partial class Settings_Notification : ContentPage
{
	public Settings_Notification()
	{
		InitializeComponent();
	}
    async void OnImage1Tapped(object sender, TappedEventArgs e)
    {

        var next = new MainPage();

        await Navigation.PushAsync(next);
    }
}