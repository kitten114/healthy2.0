namespace healthy;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}
	//���U���s
    private void OnRegisterClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("MainScreen");
    }
}