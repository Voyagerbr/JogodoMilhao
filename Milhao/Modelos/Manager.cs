namespace Modelos;

public class Manager
{
  List<Questao> Listaquestoes = new List<Questao>();

  List<int> ResponsedQuestionList = new List<int>();

  Questao currentquestao;


  void CreateQuestion(Label labelQuestion, Button btnAnswer01, Button btnAnswer02, Button btnAnswer03, Button btnAnswer04, Button btnAnswer05)
  {
    var q1 = new Questao();
    q1.Question = "Quanto é 2 + 2?";
    q1.Answer01 = "Bolsonaro";
    q1.Answer02 = "13";
    q1.Answer03 = "4";
    q1.Answer04 = "6";
    q1.Answer05 = "0";
    q1.CorrectAnswer = 3;
    q1.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q1);

    var q2 = new Questao();
    q2.Question = "Qual é a capital do Canadá?";
    q2.Answer01 = "Gotham City";
    q2.Answer02 = "Toronto";
    q2.Answer03 = "Ottawa";
    q2.Answer04 = "Montreal";
    q2.Answer05 = "Vancouver";
    q2.CorrectAnswer = 3;
    q2.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q2);

    var q3 = new Questao();
    q3.Question = "Em que ano caiu o Muro de Berlim?";
    q3.Answer01 = "1492";
    q3.Answer02 = "1989";
    q3.Answer03 = "1975";
    q3.Answer04 = "1991";
    q3.Answer05 = "2001";
    q3.CorrectAnswer = 2;
    q3.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q3);

    var q4 = new Questao();
    q4.Question = "Quem escreveu 'Crime e Castigo'?";
    q4.Answer01 = "Alguém do Chaves";
    q4.Answer02 = "Liev Tolstói";
    q4.Answer03 = "Dostoiévski";
    q4.Answer04 = "Franz Kafka";
    q4.Answer05 = "Charles Dickens";
    q4.CorrectAnswer = 3;
    q4.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q4);

    var q5 = new Questao();
    q5.Question = "Qual unidade mede frequência?";
    q5.Answer01 = "Kelvin";
    q5.Answer02 = "Hertz";
    q5.Answer03 = "Ohm";
    q5.Answer04 = "Decibéis";
    q5.Answer05 = "Pedras filosofais";
    q5.CorrectAnswer = 2;
    q5.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q5);

    var q6 = new Questao();
    q6.Question = "Quem foi o primeiro presidente dos EUA?";
    q6.Answer01 = "George Clooney";
    q6.Answer02 = "George Washington";
    q6.Answer03 = "Lincoln";
    q6.Answer04 = "Jefferson";
    q6.Answer05 = "Franklin";
    q6.CorrectAnswer = 2;
    q6.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q6);

    var q7 = new Questao();
    q7.Question = "Qual o maior planeta do sistema solar?";
    q7.Answer01 = "Saturno";
    q7.Answer02 = "Terra";
    q7.Answer03 = "Netuno";
    q7.Answer04 = "Júpiter";
    q7.Answer05 = "Mercúrio";
    q7.CorrectAnswer = 4;
    q7.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q7);

    var q8 = new Questao();
    q8.Question = "Quem descobriu a América?";
    q8.Answer01 = "Cristóvão Colombo";
    q8.Answer02 = "Vasco da Gama";
    q8.Answer03 = "Pedro Álvares Cabral";
    q8.Answer04 = "Américo Vespúcio";
    q8.Answer05 = "Elon Musk";
    q8.CorrectAnswer = 1;
    q8.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q8);

    var q9 = new Questao();
    q9.Question = "Quem pintou a Mona Lisa?";
    q9.Answer01 = "Vincent van Gogh";
    q9.Answer02 = "Claude Monet";
    q9.Answer03 = "Leonardo da Vinci";
    q9.Answer04 = "Pablo Picasso";
    q9.Answer05 = "Bob Ross";
    q9.CorrectAnswer = 3;
    q9.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q9);

    var q10 = new Questao();
    q10.Question = "Quem é o autor de 'Dom Casmurro'?";
    q10.Answer01 = "Jorge Amado";
    q10.Answer02 = "Machado de Assis";
    q10.Answer03 = "Clarice Lispector";
    q10.Answer04 = "Graciliano Ramos";
    q10.Answer05 = "Paulo Coelho";
    q10.CorrectAnswer = 2;
    q10.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q10);
    var q11 = new Questao();
    q11.Question = "Qual é o metal líquido à temperatura ambiente?";
    q11.Answer01 = "Ouro";
    q11.Answer02 = "Mercúrio";
    q11.Answer03 = "Cobre";
    q11.Answer04 = "Ferro";
    q11.Answer05 = "Prata";
    q11.CorrectAnswer = 2;
    q11.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q11);

    var q12 = new Questao();
    q12.Question = "Quem foi o líder da Revolução Cubana?";
    q12.Answer01 = "Chewbacca";
    q12.Answer02 = "Che Guevara";
    q12.Answer03 = "Fidel Castro";
    q12.Answer04 = "Simón Bolívar";
    q12.Answer05 = "Napoleão Bonaparte";
    q12.CorrectAnswer = 3;
    q12.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q12);

    var q13 = new Questao();
    q13.Question = "Em qual cidade se encontra a Torre Eiffel?";
    q13.Answer01 = "Roma";
    q13.Answer02 = "Paris";
    q13.Answer03 = "Berlim";
    q13.Answer04 = "Londres";
    q13.Answer05 = "Nova York";
    q13.CorrectAnswer = 2;
    q13.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q13);

    var q14 = new Questao();
    q14.Question = "Quem é conhecido como o 'Pai da Psicanálise'?";
    q14.Answer01 = "Sigmund Freud";
    q14.Answer02 = "Carl Jung";
    q14.Answer03 = "Jean Piaget";
    q14.Answer04 = "B. F. Skinner";
    q14.Answer05 = "Professor Xavier";
    q14.CorrectAnswer = 1;
    q14.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q14);

    var q15 = new Questao();
    q15.Question = "Qual é a fórmula química da água?";
    q15.Answer01 = "H2O";
    q15.Answer02 = "CO2";
    q15.Answer03 = "O2";
    q15.Answer04 = "NH3";
    q15.Answer05 = "CH4";
    q15.CorrectAnswer = 1;
    q15.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q15);

    var q16 = new Questao();
    q16.Question = "Em que ano o homem pisou na Lua pela primeira vez?";
    q16.Answer01 = "1965";
    q16.Answer02 = "1969";
    q16.Answer03 = "1971";
    q16.Answer04 = "1980";
    q16.Answer05 = "1957";
    q16.CorrectAnswer = 2;
    q16.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q16);

    var q17 = new Questao();
    q17.Question = "Quem pintou o teto da Capela Sistina?";
    q17.Answer01 = "Michelangelo";
    q17.Answer02 = "Leonardo da Vinci";
    q17.Answer03 = "Raphael";
    q17.Answer04 = "Donatello";
    q17.Answer05 = "Bob Esponja";
    q17.CorrectAnswer = 1;
    q17.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q17);

    var q18 = new Questao();
    q18.Question = "Qual é o país mais populoso do mundo?";
    q18.Answer01 = "Rússia";
    q18.Answer02 = "Índia";
    q18.Answer03 = "Estados Unidos";
    q18.Answer04 = "China";
    q18.Answer05 = "Westeros";
    q18.CorrectAnswer = 4;
    q18.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q18);

    var q19 = new Questao();
    q19.Question = "Qual é o nome do satélite natural da Terra?";
    q19.Answer01 = "Estrela da Morte";
    q19.Answer02 = "Lua";
    q19.Answer03 = "Titã";
    q19.Answer04 = "Europa";
    q19.Answer05 = "Plutão";
    q19.CorrectAnswer = 2;
    q19.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q19);

    var q20 = new Questao();
    q20.Question = "Quem é o autor de '1984'?";
    q20.Answer01 = "Aldous Huxley";
    q20.Answer02 = "George Orwell";
    q20.Answer03 = "J. R. R. Tolkien";
    q20.Answer04 = "F. Scott Fitzgerald";
    q20.Answer05 = "Harry Potter";
    q20.CorrectAnswer = 2;
    q20.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q20);

    var q21 = new Questao();
    q21.Question = "Qual é a língua oficial do Brasil?";
    q21.Answer01 = "Português";
    q21.Answer02 = "Espanhol";
    q21.Answer03 = "Inglês";
    q21.Answer04 = "Francês";
    q21.Answer05 = "Dothraki";
    q21.CorrectAnswer = 1;
    q21.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q21);

    var q22 = new Questao();
    q22.Question = "Qual é o maior oceano da Terra?";
    q22.Answer01 = "Atlântico";
    q22.Answer02 = "Pacífico";
    q22.Answer03 = "Índico";
    q22.Answer04 = "Ártico";
    q22.Answer05 = "Oceano de Lava";
    q22.CorrectAnswer = 2;
    q22.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q22);

    var q23 = new Questao();
    q23.Question = "Quem foi o primeiro homem a orbitar a Terra?";
    q23.Answer01 = "Neil Armstrong";
    q23.Answer02 = "Buzz Aldrin";
    q23.Answer03 = "Yuri Gagarin";
    q23.Answer04 = "Alan Shepard";
    q23.Answer05 = "Luke Skywalker";
    q23.CorrectAnswer = 3;
    q23.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q23);

    var q24 = new Questao();
    q24.Question = "Em que país as pirâmides de Gizé estão localizadas?";
    q24.Answer01 = "México";
    q24.Answer02 = "Egito";
    q24.Answer03 = "Peru";
    q24.Answer04 = "China";
    q24.Answer05 = "Nárnia";
    q24.CorrectAnswer = 2;
    q24.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q24);

    var q25 = new Questao();
    q25.Question = "Qual foi a primeira capital do Brasil?";
    q25.Answer01 = "Brasília";
    q25.Answer02 = "Rio de Janeiro";
    q25.Answer03 = "Salvador";
    q25.Answer04 = "São Paulo";
    q25.Answer05 = "Hogwarts";
    q25.CorrectAnswer = 3;
    q25.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q25);

    var q26 = new Questao();
    q26.Question = "Quem foi o inventor da lâmpada elétrica?";
    q26.Answer01 = "Thomas Edison";
    q26.Answer02 = "Nikola Tesla";
    q26.Answer03 = "Alexander Graham Bell";
    q26.Answer04 = "Galileu Galilei";
    q26.Answer05 = "Tony Stark";
    q26.CorrectAnswer = 1;
    q26.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q26);

    var q27 = new Questao();
    q27.Question = "Qual é o menor país do mundo em área?";
    q27.Answer01 = "Mônaco";
    q27.Answer02 = "Vaticano";
    q27.Answer03 = "San Marino";
    q27.Answer04 = "Malta";
    q27.Answer05 = "Ilha do Tesouro";
    q27.CorrectAnswer = 2;
    q27.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q27);

    var q28 = new Questao();
    q28.Question = "Qual o maior deserto do mundo?";
    q28.Answer01 = "Saara";
    q28.Answer02 = "Deserto da Arábia";
    q28.Answer03 = "Deserto da Antártica";
    q28.Answer04 = "Deserto de Gobi";
    q28.Answer05 = "Deserto do Tatooine";
    q28.CorrectAnswer = 3;
    q28.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q28);

    var q29 = new Questao();
    q29.Question = "Quem é o autor da teoria da relatividade?";
    q29.Answer01 = "Albert Einstein";
    q29.Answer02 = "Isaac Newton";
    q29.Answer03 = "Stephen Hawking";
    q29.Answer04 = "Marie Curie";
    q29.Answer05 = "Doc Brown";
    q29.CorrectAnswer = 1;
    q29.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q29);

    var q30 = new Questao();
    q30.Question = "Qual país é conhecido como 'a terra do sol nascente'?";
    q30.Answer01 = "China";
    q30.Answer02 = "Japão";
    q30.Answer03 = "Coreia do Sul";
    q30.Answer04 = "Vietnã";
    q30.Answer05 = "Mordor";
    q30.CorrectAnswer = 2;
    q30.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q30);
  }


  public void ProximaQuestao()

  {
    var numRandomico = Random.Shared.Next(0, Listaquestoes.Count);
    while (ResponsedQuestionList.Contains(numRandomico))
      numRandomico = Random.Shared.Next(0, Listaquestoes.Count);

    ResponsedQuestionList.Add(numRandomico);
    currentquestao = Listaquestoes[numRandomico];

    currentquestao.Desenha();
  }

  public async void VerificaCorreto(int resposta)
  {
    if (currentquestao!.EstaCorreto(resposta))
    {
      await Task.Delay(1500);
      ProximaQuestao();

    }
  }

  public Manager(Label labelQuestion, Button btnAnswer01, Button btnAnswer02, Button btnAnswer03, Button btnAnswer04, Button btnAnswer05)
  {
    CreateQuestion(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
  }

}