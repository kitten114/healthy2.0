namespace healthy.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    //�n�J
    private void OnLoginClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("MainScreen");
    }
    //���U
    private void OnRegisterClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("RegisterPage");
    }
}