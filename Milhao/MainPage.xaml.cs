namespace Milhao;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
	public void Gozei()
	{
		Navigation.PushAsync(new GamePage());
	}
}

