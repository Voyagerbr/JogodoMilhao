
using Milhao;

namespace Modelos;

public class Questao
{



    public string? Question { get; set; }
    public string? Answer01 { get; set; }
    public string? Answer02 { get; set; }
    public string? Answer03 { get; set; }
    public string? Answer04 { get; set; }
    public string? Answer05 { get; set; }
    public int CorrectAnswer { get; set; } = 0;
    private int DifficultyLvl { get; set; } = 0;

    Label? labelQuestion;
    Button? btnAnswer01;
    Button? btnAnswer02;
    Button? btnAnswer03;
    Button? btnAnswer04;
    Button? btnAnswer05;

    //=============================================================================

    public void Desenha()
    {
        this.labelQuestion!.Text = this.Question;
        this.btnAnswer01!.Text = this.Answer01;
        this.btnAnswer02!.Text = this.Answer02;
        this.btnAnswer03!.Text = this.Answer03;
        this.btnAnswer04!.Text = this.Answer04;
        this.btnAnswer05!.Text = this.Answer05;

        btnAnswer01.BackgroundColor = Colors.LightGray;
        btnAnswer02.BackgroundColor = Colors.LightGray;
        btnAnswer03.BackgroundColor = Colors.LightGray;
        btnAnswer04.BackgroundColor = Colors.LightGray;
        btnAnswer05.BackgroundColor = Colors.LightGray;
        btnAnswer01.TextColor = Colors.Black;
        btnAnswer02.TextColor = Colors.Black;
        btnAnswer03.TextColor = Colors.Black;
        btnAnswer04.TextColor = Colors.Black;
        btnAnswer05.TextColor = Colors.Black;



    }
    //=============================================================================

    public Questao()
    {

    }
    public Questao(string Question, string Answer01, string Answer02, string Answer03, string Answer04, string Answer05, int CorrectAnswer)
    {
        this.Question = Question;
        this.Answer01 = Answer01;
        this.Answer02 = Answer02;
        this.Answer03 = Answer03;
        this.Answer04 = Answer04;
        this.Answer05 = Answer05;
        this.CorrectAnswer = CorrectAnswer;
    }
    //=============================================================================

    public void ConfigurarDesenho(Label labelQuestion, Button btnAnswer01, Button btnAnswer02, Button btnAnswer03, Button btnAnswer04, Button btnAnswer05)
    {
        this.labelQuestion = labelQuestion;
        this.btnAnswer01 = btnAnswer01;
        this.btnAnswer02 = btnAnswer02;
        this.btnAnswer03 = btnAnswer03;
        this.btnAnswer04 = btnAnswer04;
        this.btnAnswer05 = btnAnswer05;
    }
    //=============================================================================

    private Button QualButton(int r)
    {
        if (r == 1)
        {
            return btnAnswer01;
        }
        else if (r == 2)
        {
            return btnAnswer02;
        }
        else if (r == 3)
        {
            return btnAnswer03;
        }
        else if (r == 4)
        {
            return btnAnswer04;
        }
        else if (r == 5)
        {
            return btnAnswer05;
        }
        else
        {
            return null;
        }
    }
    public bool VerificaResposta(int rr)
    {
        if (CorrectAnswer == rr)
        {
            var button = QualButton(rr);
            button.BackgroundColor = Colors.Green; //"#a1c9ae";
            return true;
        }
        else
        {
            var buttonCorreto = QualButton(CorrectAnswer);
            var buttonIncorreto = QualButton(rr);
            buttonCorreto.BackgroundColor = Colors.Green; //"#a1c9ae";
            buttonIncorreto.BackgroundColor = Colors.Red; //#e88e8e;

            return false;
        }
    }

    public bool EstaCorreto(int resposta)
    {
        if (CorrectAnswer == resposta)
        {
            DesenhaCorreto(resposta);
            return true;
        }
        else
        {
            DesenhaIncorreto(resposta);
            return false;
        }
    }
    private void DesenhaCorreto(int resposta)
    {
        var button = QualButton(resposta);
        DesenhaButtonCorreto(button!);
    }

    private void DesenhaIncorreto(int resposta)
    {
        var buttonCorreta = QualButton(CorrectAnswer);
        var buttonResposta = QualButton(resposta);
        DesenhaButtonIncorreto(buttonCorreta!, buttonResposta!);
    }

    private void DesenhaButtonCorreto(Button button)
    {
        button.BackgroundColor = Colors.Green;
        button.TextColor = Colors.White;

    }

    private void DesenhaButtonIncorreto(Button buttonCorreto, Button buttonResposta)
    {
        buttonCorreto.BackgroundColor = Colors.Yellow;
        buttonCorreto.TextColor = Colors.White;

        buttonResposta.BackgroundColor = Colors.Red;
        buttonResposta.TextColor = Colors.White;
    }


}