namespace Milhao;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
	public void Tremi(object sender, EventArgs e)
	{
		 Application.Current.MainPage = new GamePage();
	}
}

