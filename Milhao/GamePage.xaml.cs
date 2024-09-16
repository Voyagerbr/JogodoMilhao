namespace Milhao;

public partial class GamePage : ContentPage
{
	Questao questao;

	
    public GamePage()
    {
        InitializeComponent();
        Desenhar();
        questao.Question ="Ai meu cu";
    }
    public void Desenhar()
    {
        LabelQuestion.Text = questao.Question;
    }
}