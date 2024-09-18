namespace Milhao;

public class Questao
{
    
    private int IdPage ;

    private int DifficultyLvl;

     public string? Question;

    public string? Answer01;

    public string? Answer02;

    public string? Answer03;

    public string? Answer04;
    
    public string? Answer05;

    public int  CorrectAnswer;
    private Label Labelpergunta;
    private Button Button1;
    private Button Button2;
    private Button Button3;
    private Button Button4;
    private Button Button5;
    blic void Desenhar()
        {
            Labelpergunta.Text = labelpergunta;
            ButtonResposta1.Text = button1;
            ButtonResposta2.Text = button2;
            ButtonResposta3.Text = button3;
            ButtonResposta4.Text = button4;
            ButtonResposta5.Text = button5;
        }


    

 
    
}