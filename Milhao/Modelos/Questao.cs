namespace Modelos;

public class Questao
{

    private int IdPage;
    private int DifficultyLvl;
    public string? Question;
    public string? Answer01;
    public string? Answer02;
    public string? Answer03;
    public string? Answer04;
    public string? Answer05;
    public int CorrectAnswer;

    Label? labelQuestion;
    Button? btnAnswer01;
    Button? btnAnswer02;
    Button? btnAnswer03;
    Button? btnAnswer04;
    Button? btnAnswer05;

    public void Desenhar()
    {
        this.labelQuestion!.Text = this.Question;
        this.btnAnswer01!.Text = this.Answer01;
        this.btnAnswer02!.Text = this.Answer02;
        this.btnAnswer03!.Text = this.Answer03;
        this.btnAnswer04!.Text = this.Answer04;
        this.btnAnswer05!.Text = this.Answer05;
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
    public void Desenha()
    {
        this.labelQuestion!.Text = this.Question;
        this.btnAnswer01!.Text = this.Answer01;
        this.btnAnswer02!.Text = this.Answer02;
        this.btnAnswer03!.Text = this.Answer03;
        this.btnAnswer04!.Text = this.Answer04;
        this.btnAnswer05!.Text = this.Answer05;

    }






}