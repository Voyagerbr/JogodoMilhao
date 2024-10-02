namespace Modelos;

public class Manager
{
  List<Questao> Listaquestoes = new List<Questao>();

  List<int> ResponsedQuestionsList = new List<int>();

  Questao? CurrentQuestao;

  void CreateQuestions(Label labelPergunta, Button btnAnswer01, Button btnAnswer02, Button btnAnswer03, Button btnAnswer04, Button btnAnswer05){
    var q1 = new Questao();
    q1.Question = "Quanto é 2 + 2?";
    q1.Answer1 = "Bolsonaro";
    q1.Answer2 = "13";
    q1.Answer3 = "4";
    q1.Answer4 = "6";
    q1.Answer5 = "0";
    q1.CorrectAnswer = 3;
    q1.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q1);

    var q2 = new Questao();
    q2.Question = "Qual é a capital do Canadá?";
    q2.Answer1 = "Gotham City";
    q2.Answer2 = "Toronto";
    q2.Answer3 = "Ottawa";
    q2.Answer4 = "Montreal";
    q2.Answer5 = "Vancouver";
    q2.CorrectAnswer = 3;
    q2.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q2);

    var q3 = new Questao();
    q3.Question = "Em que ano caiu o Muro de Berlim?";
    q3.Answer1 = "1492";
    q3.Answer2 = "1989";
    q3.Answer3 = "1975";
    q3.Answer4 = "1991";
    q3.Answer5 = "2001";
    q3.CorrectAnswer = 2;
    q3.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q3);

    var q4 = new Questao();
    q4.Question = "Quem escreveu 'Crime e Castigo'?";
    q4.Answer1 = "Alguém do Chaves";
    q4.Answer2 = "Liev Tolstói";
    q4.Answer3 = "Dostoiévski";
    q4.Answer4 = "Franz Kafka";
    q4.Answer5 = "Charles Dickens";
    q4.CorrectAnswer = 3;
    q4.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q4);

    var q5 = new Questao();
    q5.Question = "Qual unidade mede frequência?";
    q5.Answer1 = "Kelvin";
    q5.Answer2 = "Hertz";
    q5.Answer3 = "Ohm";
    q5.Answer4 = "Decibéis";
    q5.Answer5 = "Pedras filosofais";
    q5.CorrectAnswer = 2;
    q5.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q5);

    var q6 = new Questao();
    q6.Question = "Quem foi o primeiro presidente dos EUA?";
    q6.Answer1 = "George Clooney";
    q6.Answer2 = "George Washington";
    q6.Answer3 = "Lincoln";
    q6.Answer4 = "Jefferson";
    q6.Answer5 = "Franklin";
    q6.CorrectAnswer = 2;
    q6.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q6);

    var q7 = new Questao();
    q7.Question = "Qual o maior planeta do sistema solar?";
    q7.Answer1 = "Saturno";
    q7.Answer2 = "Terra";
    q7.Answer3 = "Netuno";
    q7.Answer4 = "Júpiter";
    q7.Answer5 = "Mercúrio";
    q7.CorrectAnswer = 4;
    q7.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q7);

    var q8 = new Questao();
    q8.Question = "Quem descobriu a América?";
    q8.Answer1 = "Cristóvão Colombo";
    q8.Answer2 = "Vasco da Gama";
    q8.Answer3 = "Pedro Álvares Cabral";
    q8.Answer4 = "Américo Vespúcio";
    q8.Answer5 = "Elon Musk";
    q8.CorrectAnswer = 1;
    q8.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q8);

    var q9 = new Questao();
    q9.Question = "Quem pintou a Mona Lisa?";
    q9.Answer1 = "Vincent van Gogh";
    q9.Answer2 = "Claude Monet";
    q9.Answer3 = "Leonardo da Vinci";
    q9.Answer4 = "Pablo Picasso";
    q9.Answer5 = "Bob Ross";
    q9.CorrectAnswer = 3;
    q9.ConfiguraEstruturaDesenho(labelPergunta, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    listaQuestoes.Add(q9);

    var q10 = new Questao();
    q10.Question = "Quem é o autor de 'Dom Casmurro'?";
    q10.Answer1 = "Jorge Amado";
    q10.Answer2 = "Machado de Assis";
    q10.Answer3 = "Clarice Lispector";
    q10.Answer4 = "Graciliano Ramos";
    q10.Answer5 = "Paulo Coelho";
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