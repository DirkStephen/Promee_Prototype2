namespace Promee_Prototype2.Promee_LoginSignUp;

public partial class Promee_Login : ContentPage
{
	public Promee_Login()
	{
		InitializeComponent();
	}
	public async void OnLogin(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}
	public async void OnSignUp(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Promee_SignUp());
	}
}