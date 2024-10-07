
using Modelos;

public class RetiraTres : IAjudas
{
    public override void RealizaAjuda(Questao questao)
    {
        switch (questao.CorrectAnswer)
        {
            case 1:
                btnAnswer02.IsVisible = false;
                btnAnswer03.IsVisible = false;
                btnAnswer04.IsVisible = false;
                break;

            case 2:
                btnAnswer01.IsVisible = false;
                btnAnswer03.IsVisible = false;
                btnAnswer05.IsVisible = false;
                break;

            case 3:
                btnAnswer01.IsVisible = false;
                btnAnswer02.IsVisible = false;
                btnAnswer04.IsVisible = false;
                break;

            case 4:
                btnAnswer03.IsVisible = false;
                btnAnswer02.IsVisible = false;
                btnAnswer05.IsVisible = false;
                break;

            case 5:
                btnAnswer02.IsVisible = false;
                btnAnswer03.IsVisible = false;
                btnAnswer04.IsVisible = false;
                break;
        }
    }
}