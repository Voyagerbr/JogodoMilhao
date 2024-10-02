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

    Label? labelQuestions;
    Button? btnAnswer01;
    Button? btnAnswer02;
    Button? btnAnswer03;
    Button? btnAnswer04;
    Button? btnAnswer05;

    //=============================================================================

    public void Desenhar()
    {
        this.labelQuestions!.Text = this.Questions;
        this.btnAnswer01!.Text = this.Answer01;
        this.btnAnswer02!.Text = this.Answer02;
        this.btnAnswer03!.Text = this.Answer03;
        this.btnAnswer04!.Text = this.Answer04;
        this.btnAnswer05!.Text = this.Answer05;
    }
    //=============================================================================
    public Questao(string Questions, string Answer01, string Answer02, string Answer03, string Answer04, string Answer05, int CorrectAnswer)
    {
        this.Questions = Questions;
        this.Answer01 = Answer01;
        this.Answer02 = Answer02;
        this.Answer03 = Answer03;
        this.Answer04 = Answer04;
        this.Answer05 = Answer05;
        this.CorrectAnswer = CorrectAnswer;
    }
    //=============================================================================
    public void Desenha()
    {
        this.labelQuestions!.Text = this.Questions;
        this.btnAnswer01!.Text = this.Answer01;
        this.btnAnswer02!.Text = this.Answer02;
        this.btnAnswer03!.Text = this.Answer03;
        this.btnAnswer04!.Text = this.Answer04;
        this.btnAnswer05!.Text = this.Answer05;

        this.btnAnswer01!.BackgroundColor = Colors.DarkBlue;
        this.btnAnswer01!.TextColor = Colors.Black;
        this.btnAnswer02!.BackgroundColor = Colors.DarkBlue;
        this.btnAnswer02!.TextColor = Colors.Black;
        this.btnAnswer03!.BackgroundColor = Colors.DarkBlue;
        this.btnAnswer03!.TextColor = Colors.Black;
        this.btnAnswer04!.BackgroundColor = Colors.DarkBlue;
        this.btnAnswer04!.TextColor = Colors.Black;
        this.btnAnswer05!.BackgroundColor = Colors.DarkBlue;
        this.btnAnswer05!.TextColor = Colors.Black;
    }
     public void ConfiguraEstruturaDesenho (Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5){
        LabelPergunta = labelpergunta;
        ButtonResposta1 = button1;
        ButtonResposta2 = button2;
        ButtonResposta3 = button3;
        ButtonResposta4 = button4;
        ButtonResposta5 = button5;
    }
    //=============================================================================

 private Button QualButton(int r){
        if(r == 1){
            return btnAnswer01;
        }
        else if(r == 2){
            return btnAnswer02;
        }
        else if (r == 3){
            return btnAnswer03;
        }
        else if (r == 4){
            return btnAnswer04;
        }
        else if (r == 5 ){
            return btnAnswer05;
        }
        else{
            return null;
        }
    }
     public bool VerificaResposta(int rr){
        if(CorrectAnswer == rr){
            var button = QualButton(rr);
            button.BackgroundColor = Colors.Green; //"#a1c9ae";
            return true;
        }
        else{
            var buttonCorreto = QualButton(CorrectAnswer);
            var buttonIncorreto = QualButton(rr);
            buttonCorreto.BackgroundColor = Colors.Green; //"#a1c9ae";
            buttonIncorreto.BackgroundColor = Colors.Red; //#e88e8e;

            return false;
        }
    }


}