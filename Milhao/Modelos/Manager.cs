namespace Modelos;

public class Manager
{
    List<Questao> Listaquestoes = new List<Questao>();

    List<int> ResponsedQuestionsList = new List<int>();

    Questao CurrentQuestao;

    void CreateQuestions(Labelpergunta, Button1, Button2, Button3, Button4, Button5)
    {
        var Q1 = new Questao();
        Q1.Question = "Qual o tamanho do seu pinto?"
        Q1.Answer01 = "0.5m";
        Q1.Answer02 = "";
        Q1.Answer03 = "";
        Q1.A
    }
    public void NextQuestion()
    {
        var RandomNumber = RandomNumber.Shared.Next(0, Listaquestoes.Count -1),
        while (Listaquestoes)
        
    }

    public Manager(Label Labelpergunta, Button Button1, Button Button2, Button Button3, Button Button4, Button Button5)
    {
        CreateQuestions(Labelpergunta, Button1, Button2, Button3, Button4, Button5);
    }

}