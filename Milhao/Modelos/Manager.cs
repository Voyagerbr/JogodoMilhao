namespace Modelos;

public class Manager
{
  List<Questao> Listaquestoes = new List<Questao>();

  List<int> ResponsedQuestionsList = new List<int>();

  Questao? CurrentQuestao;

  void CreateQuestions(Label labelPergunta, Button btnAnswer01, Button btnAnswer02, Button btnAnswer03, Button btnAnswer04, Button btnAnswer05){
    var q1 = new Questao();
    q1.Question = "Quanto é 2 + 2?";
    q1.Answer01 = "Bolsonaro";
    q1.Answer02 = "13";
    q1.Answer03 = "4";
    q1.Answer04 = "6";
    q1.Answer05 = "0";
    q1.CorrectAnswer = 3;
    q1.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q1);

    var q2 = new Questao();
    q2.Question = "Qual é a capital do Canadá?";
    q2.Answer01 = "Gotham City";
    q2.Answer02 = "Toronto";
    q2.Answer03 = "Ottawa";
    q2.Answer04 = "Montreal";
    q2.Answer05 = "Vancouver";
    q2.CorrectAnswer = 3;
    q2.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q2);

    var q3 = new Questao();
    q3.Question = "Em que ano caiu o Muro de Berlim?";
    q3.Answer01 = "1492";
    q3.Answer02 = "1989";
    q3.Answer03 = "1975";
    q3.Answer04 = "1991";
    q3.Answer05 = "2001";
    q3.CorrectAnswer = 2;
    q3.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q3);

    var q4 = new Questao();
    q4.Question = "Quem escreveu 'Crime e Castigo'?";
    q4.Answer01 = "Alguém do Chaves";
    q4.Answer02 = "Liev Tolstói";
    q4.Answer03 = "Dostoiévski";
    q4.Answer04 = "Franz Kafka";
    q4.Answer05 = "Charles Dickens";
    q4.CorrectAnswer = 3;
    q4.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q4);

    var q5 = new Questao();
    q5.Question = "Qual unidade mede frequência?";
    q5.Answer01 = "Kelvin";
    q5.Answer02 = "Hertz";
    q5.Answer03 = "Ohm";
    q5.Answer04 = "Decibéis";
    q5.Answer05 = "Pedras filosofais";
    q5.CorrectAnswer = 2;
    q5.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q5);

    var q6 = new Questao();
    q6.Question = "Quem foi o primeiro presidente dos EUA?";
    q6.Answer01 = "George Clooney";
    q6.Answer02 = "George Washington";
    q6.Answer03 = "Lincoln";
    q6.Answer04 = "Jefferson";
    q6.Answer05 = "Franklin";
    q6.CorrectAnswer = 2;
    q6.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q6);

    var q7 = new Questao();
    q7.Question = "Qual o maior planeta do sistema solar?";
    q7.Answer01 = "Saturno";
    q7.Answer02 = "Terra";
    q7.Answer03 = "Netuno";
    q7.Answer04 = "Júpiter";
    q7.Answer05 = "Mercúrio";
    q7.CorrectAnswer = 4;
    q7.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q7);

    var q8 = new Questao();
    q8.Question = "Quem descobriu a América?";
    q8.Answer01 = "Cristóvão Colombo";
    q8.Answer02 = "Vasco da Gama";
    q8.Answer03 = "Pedro Álvares Cabral";
    q8.Answer04 = "Américo Vespúcio";
    q8.Answer05 = "Elon Musk";
    q8.CorrectAnswer = 1;
    q8.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q8);

    var q9 = new Questao();
    q9.Question = "Quem pintou a Mona Lisa?";
    q9.Answer01 = "Vincent van Gogh";
    q9.Answer02 = "Claude Monet";
    q9.Answer03 = "Leonardo da Vinci";
    q9.Answer04 = "Pablo Picasso";
    q9.Answer05 = "Bob Ross";
    q9.CorrectAnswer = 3;
    q9.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q9);

    var q10 = new Questao();
    q10.Question = "Quem é o autor de 'Dom Casmurro'?";
    q10.Answer01 = "Jorge Amado";
    q10.Answer02 = "Machado de Assis";
    q10.Answer03 = "Clarice Lispector";
    q10.Answer04 = "Graciliano Ramos";
    q10.Answer05 = "Paulo Coelho";
    q10.CorrectAnswer = 2;
    q10.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q10);
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