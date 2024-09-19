namespace Modelos;

public class Manager
{
    List<Questao> Listaquestoes = new List<Questao>();

    List<int> ResponsedQuestionsList = new List<int>();

    Questao CurrentQuestao;

     private void CriarPerguntas(Label labelPergunta, Button btnanswer01, Button btnanswer02, Button btnanswer03, Button btnanswer04, Button btnanswer05)
  {
        var Q1 = new Questao();
        Q1.Question = "Sim?";
        Q1.Answer01 = "";
        Q1.Answer02 = "";
        Q1.Answer03 = "";
        Q1.Answer04 = "";
        Q1.Answer05 = "";
    }
    public void ProximaQuestao()
  {
    var numRandomico = Random.Shared.Next(0, Listaquestoes.Count);
    while (ResponsedQuestionsList.Contains(numRandomico))
      numRandomico = Random.Shared.Next(0, Listaquestoes.Count);

    ResponsedQuestionsList.Add(numRandomico);
    CurrentQuestao = Listaquestoes [numRandomico];
    
    CurrentQuestao.Desenha();
  }

    public Manager(Label Labelpergunta, Button Button1, Button Button2, Button Button3, Button Button4, Button Button5)
    {
        CreateQuestions(Labelpergunta, Button1, Button2, Button3, Button4, Button5);
    }

}