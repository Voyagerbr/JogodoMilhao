namespace Milhao;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
	public void Gozei(object sender, EventArgs e)
	{
		Navigation.PushAsync(new GamePage());
	}
}

