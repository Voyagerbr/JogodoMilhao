using Modelos;
namespace Milhao;

public partial class GamePage : ContentPage
{
    Manager gerenciador;


    public GamePage()
    {
        InitializeComponent();

        gerenciador = new Manager(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
        gerenciador.ProximaQuestao();

    }
    private void OnBtnResposta01Clicked(object sender, EventArgs e)
    {
        gerenciador!.VerificaCorreto(1);
    }

    private void OnBtnResposta02Clicked(object sender, EventArgs e)
    {
        gerenciador!.VerificaCorreto(2);
    }

    private void OnBtnResposta03Clicked(object sender, EventArgs e)
    {
        gerenciador!.VerificaCorreto(3);
    }

    private void OnBtnResposta04Clicked(object sender, EventArgs e)
    {
        gerenciador!.VerificaCorreto(4);
    }

    private void OnBtnResposta05Clicked(object sender, EventArgs e)
    {
        gerenciador!.VerificaCorreto(5);
    }

    int Pulei = 3;
    void OnAjudaPuloClicked(object s, EventArgs e)
    {
        if (Pulei == 0){
             (s as Button).IsVisible = false;
        }
       else {
         gerenciador.ProximaQuestao();
         Pulei --;
       }
       
    }

}
