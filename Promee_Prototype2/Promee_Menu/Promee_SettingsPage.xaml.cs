
using Promee_Prototype2.Promee_Settings;

namespace Promee_Prototype2.Promee_Menu;

public partial class Promee_SettingsPage : ContentPage
{
	public Promee_SettingsPage()
	{
		InitializeComponent();
	}
    async void OnImage1Tapped(object sender, TappedEventArgs e)
    {

        var next = new Settings_Notification();

        await Navigation.PushAsync(next);
    }
    private async void OnImage2Tapped(object sender, TappedEventArgs e)
    {

        var next = new Settings_Language();

        await Navigation.PushAsync(next);
    }
    private async void OnImage3Tapped(object sender, TappedEventArgs e)
    {

        var next = new Settings_About();

        await Navigation.PushAsync(next);
    }
    private async void OnImage4Tapped(object sender, TappedEventArgs e)
    {

        var next = new Settings_Help();

        await Navigation.PushAsync(next);
    }
}