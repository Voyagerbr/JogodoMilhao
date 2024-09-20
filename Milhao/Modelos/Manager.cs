namespace Modelos;

public class Manager
{
  List<Questao> Listaquestoes = new List<Questao>();

  List<int> ResponsedQuestionsList = new List<int>();

  Questao? CurrentQuestao;

  private void CreateQuestions(Label labelQuestion, Button btnAnswer01, Button btnAnswer02, Button btnAnswer03, Button btnAnswer04, Button btnAnswer05)
  {
   
  }
  public void ProximaQuestao()
  {
    var numRandomico = Random.Shared.Next(0, Listaquestoes.Count);
    while (ResponsedQuestionsList.Contains(numRandomico))
      numRandomico = Random.Shared.Next(0, Listaquestoes.Count);

    ResponsedQuestionsList.Add(numRandomico);
    CurrentQuestao = Listaquestoes[numRandomico];

    CurrentQuestao.Desenha();
  }

  public Manager(Label labelQuestion, Button btnAnswer01, Button btnAnswer02, Button btnAnswer03, Button btnAnswer04, Button btnAnswer05)
  {
    CreateQuestions(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
  }

}