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
  
  var q31 = new Questao();
    q31.Question = "Qual é a capital da Austrália?";
    q31.Answer01 = "Sydney";
    q31.Answer02 = "Melbourne";
    q31.Answer03 = "Canberra";
    q31.Answer04 = "Perth";
    q31.Answer05 = "Hogwarts";
    q31.CorrectAnswer = 3;
    q31.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q31);

    var q32 = new Questao();
    q32.Question = "Quem escreveu 'O Pequeno Príncipe'?";
    q32.Answer01 = "Antoine de Saint-Exupéry";
    q32.Answer02 = "Jules Verne";
    q32.Answer03 = "Victor Hugo";
    q32.Answer04 = "Fiódor Dostoiévski";
    q32.Answer05 = "Pikachu";
    q32.CorrectAnswer = 1;
    q32.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q32);

    var q33 = new Questao();
    q33.Question = "Qual é o maior animal terrestre?";
    q33.Answer01 = "Elefante";
    q33.Answer02 = "Girafa";
    q33.Answer03 = "Hipopótamo";
    q33.Answer04 = "Rinoceronte";
    q33.Answer05 = "Godzilla";
    q33.CorrectAnswer = 1;
    q33.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q33);

    var q34 = new Questao();
    q34.Question = "Quantos estados tem o Brasil?";
    q34.Answer01 = "25";
    q34.Answer02 = "26";
    q34.Answer03 = "27";
    q34.Answer04 = "28";
    q34.Answer05 = "50, se contar o Texas";
    q34.CorrectAnswer = 2;
    q34.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q34);

    var q35 = new Questao();
    q35.Question = "Qual é o menor osso do corpo humano?";
    q35.Answer01 = "Fêmur";
    q35.Answer02 = "Esterno";
    q35.Answer03 = "Estribo";
    q35.Answer04 = "Vértebra";
    q35.Answer05 = "Sabre de luz";
    q35.CorrectAnswer = 3;
    q35.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q35);

    var q36 = new Questao();
    q36.Question = "Quem pintou 'Guernica'?";
    q36.Answer01 = "Pablo Picasso";
    q36.Answer02 = "Salvador Dalí";
    q36.Answer03 = "Vincent van Gogh";
    q36.Answer04 = "Claude Monet";
    q36.Answer05 = "Bob Ross";
    q36.CorrectAnswer = 1;
    q36.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q36);

    var q37 = new Questao();
    q37.Question = "Qual é o elemento químico representado pelo símbolo 'O'?";
    q37.Answer01 = "Oxigênio";
    q37.Answer02 = "Ouro";
    q37.Answer03 = "Osmium";
    q37.Answer04 = "Ósmio";
    q37.Answer05 = "Óleo de Lorenzo";
    q37.CorrectAnswer = 1;
    q37.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q37);

    var q38 = new Questao();
    q38.Question = "Qual foi o primeiro presidente dos Estados Unidos?";
    q38.Answer01 = "George Washington";
    q38.Answer02 = "Thomas Jefferson";
    q38.Answer03 = "Abraham Lincoln";
    q38.Answer04 = "John Adams";
    q38.Answer05 = "Capitão América";
    q38.CorrectAnswer = 1;
    q38.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q38);

    var q39 = new Questao();
    q39.Question = "Qual é a moeda oficial do Japão?";
    q39.Answer01 = "Yen";
    q39.Answer02 = "Won";
    q39.Answer03 = "Euro";
    q39.Answer04 = "Dólar";
    q39.Answer05 = "Créditos da Estrela da Morte";
    q39.CorrectAnswer = 1;
    q39.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q39);

    var q40 = new Questao();
    q40.Question = "Qual é a fórmula do gás carbônico?";
    q40.Answer01 = "CO2";
    q40.Answer02 = "H2O";
    q40.Answer03 = "CH4";
    q40.Answer04 = "O2";
    q40.Answer05 = "N2O";
    q40.CorrectAnswer = 1;
    q40.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q40);

    var q41 = new Questao();
    q41.Question = "Quem escreveu 'Cem Anos de Solidão'?";
    q41.Answer01 = "Gabriel García Márquez";
    q41.Answer02 = "Jorge Luis Borges";
    q41.Answer03 = "Isabel Allende";
    q41.Answer04 = "Mario Vargas Llosa";
    q41.Answer05 = "Harry Potter";
    q41.CorrectAnswer = 1;
    q41.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q41);

    var q42 = new Questao();
    q42.Question = "Qual é o maior continente do mundo?";
    q42.Answer01 = "Ásia";
    q42.Answer02 = "África";
    q42.Answer03 = "América do Sul";
    q42.Answer04 = "Europa";
    q42.Answer05 = "Westeros";
    q42.CorrectAnswer = 1;
    q42.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q42);

    var q43 = new Questao();
    q43.Question = "Qual planeta é conhecido como 'o planeta vermelho'?";
    q43.Answer01 = "Júpiter";
    q43.Answer02 = "Marte";
    q43.Answer03 = "Vênus";
    q43.Answer04 = "Saturno";
    q43.Answer05 = "Kripton";
    q43.CorrectAnswer = 2;
    q43.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q43);

    var q44 = new Questao();
    q44.Question = "Qual foi a primeira mulher a ganhar o Prêmio Nobel?";
    q44.Answer01 = "Marie Curie";
    q44.Answer02 = "Rosalind Franklin";
    q44.Answer03 = "Ada Lovelace";
    q44.Answer04 = "Jane Goodall";
    q44.Answer05 = "Princesa Leia";
    q44.CorrectAnswer = 1;
    q44.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q44);

    var q45 = new Questao();
    q45.Question = "Qual é o rio mais longo do mundo?";
    q45.Answer01 = "Rio Amazonas";
    q45.Answer02 = "Rio Nilo";
    q45.Answer03 = "Rio Yangtzé";
    q45.Answer04 = "Rio Mississipi";
    q45.Answer05 = "Rio de Lágrimas";
    q45.CorrectAnswer = 2;
    q45.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q45);

    var q46 = new Questao();
    q46.Question = "Qual é o ponto mais alto da Terra?";
    q46.Answer01 = "Monte Everest";
    q46.Answer02 = "Monte Kilimanjaro";
    q46.Answer03 = "Mont Blanc";
    q46.Answer04 = "Monte Fuji";
    q46.Answer05 = "Monte Olimpo (Marte)";
    q46.CorrectAnswer = 1;
    q46.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q46);

    var q47 = new Questao();
    q47.Question = "Quem descobriu a penicilina?";
    q47.Answer01 = "Alexander Fleming";
    q47.Answer02 = "Louis Pasteur";
    q47.Answer03 = "Marie Curie";
    q47.Answer04 = "Gregor Mendel";
    q47.Answer05 = "Dr. House";
    q47.CorrectAnswer = 1;
    q47.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q47);

    var q48 = new Questao();
    q48.Question = "Qual é o metal mais abundante na crosta terrestre?";
    q48.Answer01 = "Alumínio";
    q48.Answer02 = "Ferro";
    q48.Answer03 = "Cobre";
    q48.Answer04 = "Chumbo";
    q48.Answer05 = "Adamantium";
    q48.CorrectAnswer = 1;
    q48.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q48);

    var q49 = new Questao();
    q49.Question = "Qual é a fórmula química da água?";
    q49.Answer01 = "H2O";
    q49.Answer02 = "CO2";
    q49.Answer03 = "NaCl";
    q49.Answer04 = "C6H12O6";
    q49.Answer05 = "Wakanda Forever";
    q49.CorrectAnswer = 1;
    q49.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q49);

    var q50 = new Questao();
    q50.Question = "Qual foi o primeiro satélite artificial da Terra?";
    q50.Answer01 = "Sputnik 1";
    q50.Answer02 = "Explorer 1";
    q50.Answer03 = "Apollo 11";
    q50.Answer04 = "Vostok 1";
    q50.Answer05 = "Estrela da Morte";
    q50.CorrectAnswer = 1;
    q50.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q50);

     var q51 = new Questao();
    q51.Question = "Qual é o nome do cientista que propôs a teoria da relatividade?";
    q51.Answer01 = "Albert Einstein";
    q51.Answer02 = "Isaac Newton";
    q51.Answer03 = "Galileu Galilei";
    q51.Answer04 = "Stephen Hawking";
    q51.Answer05 = "Sheldon Cooper";
    q51.CorrectAnswer = 1;
    q51.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q51);

    var q52 = new Questao();
    q52.Question = "Quem é o autor de '1984'?";
    q52.Answer01 = "George Orwell";
    q52.Answer02 = "Aldous Huxley";
    q52.Answer03 = "Ray Bradbury";
    q52.Answer04 = "J. R. R. Tolkien";
    q52.Answer05 = "Optimus Prime";
    q52.CorrectAnswer = 1;
    q52.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q52);

    var q53 = new Questao();
    q53.Question = "Qual é o planeta mais próximo do Sol?";
    q53.Answer01 = "Vênus";
    q53.Answer02 = "Terra";
    q53.Answer03 = "Mercúrio";
    q53.Answer04 = "Marte";
    q53.Answer05 = "Pandora";
    q53.CorrectAnswer = 3;
    q53.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q53);

    var q54 = new Questao();
    q54.Question = "Quantos músculos um ser humano adulto tem?";
    q54.Answer01 = "500";
    q54.Answer02 = "206";
    q54.Answer03 = "639";
    q54.Answer04 = "850";
    q54.Answer05 = "Todos os do The Rock";
    q54.CorrectAnswer = 3;
    q54.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q54);

    var q55 = new Questao();
    q55.Question = "Quem pintou a Mona Lisa?";
    q55.Answer01 = "Leonardo da Vinci";
    q55.Answer02 = "Michelangelo";
    q55.Answer03 = "Raphael";
    q55.Answer04 = "Donatello";
    q55.Answer05 = "As Tartarugas Ninja";
    q55.CorrectAnswer = 1;
    q55.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q55);

    var q56 = new Questao();
    q56.Question = "Quem descobriu o Brasil?";
    q56.Answer01 = "Pedro Álvares Cabral";
    q56.Answer02 = "Cristóvão Colombo";
    q56.Answer03 = "Américo Vespúcio";
    q56.Answer04 = "Fernão de Magalhães";
    q56.Answer05 = "Indiana Jones";
    q56.CorrectAnswer = 1;
    q56.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q56);

    var q57 = new Questao();
    q57.Question = "Quantos segundos tem uma hora?";
    q57.Answer01 = "3.600";
    q57.Answer02 = "1.800";
    q57.Answer03 = "6.000";
    q57.Answer04 = "2.400";
    q57.Answer05 = "Depende da internet";
    q57.CorrectAnswer = 1;
    q57.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q57);

    var q58 = new Questao();
    q58.Question = "Qual é o oceano que banha o litoral leste do Brasil?";
    q58.Answer01 = "Oceano Atlântico";
    q58.Answer02 = "Oceano Pacífico";
    q58.Answer03 = "Oceano Índico";
    q58.Answer04 = "Oceano Ártico";
    q58.Answer05 = "Mar de Netuno";
    q58.CorrectAnswer = 1;
    q58.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q58);

    var q59 = new Questao();
    q59.Question = "Qual é o maior país da América do Sul?";
    q59.Answer01 = "Brasil";
    q59.Answer02 = "Argentina";
    q59.Answer03 = "Colômbia";
    q59.Answer04 = "Chile";
    q59.Answer05 = "Wakanda";
    q59.CorrectAnswer = 1;
    q59.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q59);

    var q60 = new Questao();
    q60.Question = "Qual foi a primeira mulher a ir ao espaço?";
    q60.Answer01 = "Valentina Tereshkova";
    q60.Answer02 = "Sally Ride";
    q60.Answer03 = "Mae Jemison";
    q60.Answer04 = "Peggy Whitson";
    q60.Answer05 = "Princesa Leia";
    q60.CorrectAnswer = 1;
    q60.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q60);

    var q61 = new Questao();
    q61.Question = "Quem é o autor de 'Dom Quixote'?";
    q61.Answer01 = "Miguel de Cervantes";
    q61.Answer02 = "Gabriel García Márquez";
    q61.Answer03 = "Jorge Luis Borges";
    q61.Answer04 = "Mario Vargas Llosa";
    q61.Answer05 = "Shrek";
    q61.CorrectAnswer = 1;
    q61.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q61);

    var q62 = new Questao();
    q62.Question = "Em que ano o homem pisou na Lua pela primeira vez?";
    q62.Answer01 = "1969";
    q62.Answer02 = "1972";
    q62.Answer03 = "1965";
    q62.Answer04 = "1959";
    q62.Answer05 = "Em uma galáxia muito, muito distante";
    q62.CorrectAnswer = 1;
    q62.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q62);

    var q63 = new Questao();
    q63.Question = "Quem é o autor de 'A Divina Comédia'?";
    q63.Answer01 = "Dante Alighieri";
    q63.Answer02 = "William Shakespeare";
    q63.Answer03 = "Homer";
    q63.Answer04 = "Virgílio";
    q63.Answer05 = "Al Pacino";
    q63.CorrectAnswer = 1;
    q63.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q63);

    var q64 = new Questao();
    q64.Question = "Qual foi o primeiro animal a ser clonado com sucesso?";
    q64.Answer01 = "Ovelha";
    q64.Answer02 = "Cavalo";
    q64.Answer03 = "Cachorro";
    q64.Answer04 = "Gato";
    q64.Answer05 = "Gremlin";
    q64.CorrectAnswer = 1;
    q64.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q64);

    var q65 = new Questao();
    q65.Question = "Qual é o maior deserto do mundo?";
    q65.Answer01 = "Deserto do Saara";
    q65.Answer02 = "Deserto da Antártica";
    q65.Answer03 = "Deserto de Gobi";
    q65.Answer04 = "Deserto de Atacama";
    q65.Answer05 = "Deserto de Tatooine";
    q65.CorrectAnswer = 2;
    q65.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q65);

    var q66 = new Questao();
    q66.Question = "Qual é o órgão mais pesado do corpo humano?";
    q66.Answer01 = "Fígado";
    q66.Answer02 = "Cérebro";
    q66.Answer03 = "Pulmões";
    q66.Answer04 = "Coração";
    q66.Answer05 = "Alma";
    q66.CorrectAnswer = 1;
    q66.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q66);

    var q67 = new Questao();
    q67.Question = "Quantos litros de sangue tem um ser humano adulto?";
    q67.Answer01 = "5 a 6 litros";
    q67.Answer02 = "3 a 4 litros";
    q67.Answer03 = "8 a 10 litros";
    q67.Answer04 = "10 a 12 litros";
    q67.Answer05 = "O suficiente para não virar vampiro";
    q67.CorrectAnswer = 1;
    q67.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q67);

    var q68 = new Questao();
    q68.Question = "Quem é o autor de 'Cem Anos de Solidão'?";
    q68.Answer01 = "Gabriel García Márquez";
    q68.Answer02 = "Jorge Amado";
    q68.Answer03 = "Mario Vargas Llosa";
    q68.Answer04 = "Isabel Allende";
    q68.Answer05 = "Dr. Estranho";
    q68.CorrectAnswer = 1;
    q68.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q68);

    var q69 = new Questao();
    q69.Question = "Qual é o maior animal terrestre?";
    q69.Answer01 = "Elefante";
    q69.Answer02 = "Rinoceronte";
    q69.Answer03 = "Hipopótamo";
    q69.Answer04 = "Girafa";
    q69.Answer05 = "Godzilla";
    q69.CorrectAnswer = 1;
    q69.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q69);

    var q70 = new Questao();
    q70.Question = "Qual é o maior continente em extensão territorial?";
    q70.Answer01 = "Ásia";
    q70.Answer02 = "África";
    q70.Answer03 = "Europa";
    q70.Answer04 = "América do Norte";
    q70.Answer05 = "Planeta Vegeta";
    q70.CorrectAnswer = 1;
    q70.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q70);

     var q71 = new Questao();
    q71.Question = "Quantos elementos químicos existem na tabela periódica?";
    q71.Answer01 = "118";
    q71.Answer02 = "100";
    q71.Answer03 = "112";
    q71.Answer04 = "120";
    q71.Answer05 = "42";
    q71.CorrectAnswer = 1;
    q71.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q71);

    var q72 = new Questao();
    q72.Question = "Qual é o maior órgão do corpo humano?";
    q72.Answer01 = "Pele";
    q72.Answer02 = "Fígado";
    q72.Answer03 = "Coração";
    q72.Answer04 = "Pulmão";
    q72.Answer05 = "Estômago de quem gosta de pizza";
    q72.CorrectAnswer = 1;
    q72.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q72);

    var q73 = new Questao();
    q73.Question = "Quem escreveu 'O Morro dos Ventos Uivantes'?";
    q73.Answer01 = "Emily Brontë";
    q73.Answer02 = "Jane Austen";
    q73.Answer03 = "Agatha Christie";
    q73.Answer04 = "Mary Shelley";
    q73.Answer05 = "Lady Gaga";
    q73.CorrectAnswer = 1;
    q73.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q73);

    var q74 = new Questao();
    q74.Question = "Qual é o maior osso do corpo humano?";
    q74.Answer01 = "Fêmur";
    q74.Answer02 = "Tíbia";
    q74.Answer03 = "Úmero";
    q74.Answer04 = "Rádio";
    q74.Answer05 = "Clavícula de Superman";
    q74.CorrectAnswer = 1;
    q74.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q74);

    var q75 = new Questao();
    q75.Question = "Quem pintou o teto da Capela Sistina?";
    q75.Answer01 = "Michelangelo";
    q75.Answer02 = "Leonardo da Vinci";
    q75.Answer03 = "Rafael";
    q75.Answer04 = "Donatello";
    q75.Answer05 = "Bob Ross";
    q75.CorrectAnswer = 1;
    q75.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q75);

    var q76 = new Questao();
    q76.Question = "Qual é a capital da Austrália?";
    q76.Answer01 = "Canberra";
    q76.Answer02 = "Sydney";
    q76.Answer03 = "Melbourne";
    q76.Answer04 = "Brisbane";
    q76.Answer05 = "Gotham";
    q76.CorrectAnswer = 1;
    q76.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q76);

    var q77 = new Questao();
    q77.Question = "Quem é o autor de 'O Pequeno Príncipe'?";
    q77.Answer01 = "Antoine de Saint-Exupéry";
    q77.Answer02 = "Jules Verne";
    q77.Answer03 = "Victor Hugo";
    q77.Answer04 = "Charles Dickens";
    q77.Answer05 = "Homer Simpson";
    q77.CorrectAnswer = 1;
    q77.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q77);

    var q78 = new Questao();
    q78.Question = "Qual é a fórmula química do sal de cozinha?";
    q78.Answer01 = "NaCl";
    q78.Answer02 = "H2O";
    q78.Answer03 = "CO2";
    q78.Answer04 = "C6H12O6";
    q78.Answer05 = "Sazon";
    q78.CorrectAnswer = 1;
    q78.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q78);

    var q79 = new Questao();
    q79.Question = "Qual é a unidade de medida da intensidade da corrente elétrica?";
    q79.Answer01 = "Ampère";
    q79.Answer02 = "Volt";
    q79.Answer03 = "Ohm";
    q79.Answer04 = "Watt";
    q79.Answer05 = "GigaWatts";
    q79.CorrectAnswer = 1;
    q79.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q79);

    var q80 = new Questao();
    q80.Question = "Quem é o autor de 'Moby Dick'?";
    q80.Answer01 = "Herman Melville";
    q80.Answer02 = "Mark Twain";
    q80.Answer03 = "Charles Dickens";
    q80.Answer04 = "F. Scott Fitzgerald";
    q80.Answer05 = "Aquaman";
    q80.CorrectAnswer = 1;
    q80.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q80);

    var q81 = new Questao();
    q81.Question = "Qual é a capital do Canadá?";
    q81.Answer01 = "Ottawa";
    q81.Answer02 = "Toronto";
    q81.Answer03 = "Vancouver";
    q81.Answer04 = "Montreal";
    q81.Answer05 = "Winterfell";
    q81.CorrectAnswer = 1;
    q81.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q81);

    var q82 = new Questao();
    q82.Question = "Qual é o país mais populoso do mundo?";
    q82.Answer01 = "China";
    q82.Answer02 = "Índia";
    q82.Answer03 = "Estados Unidos";
    q82.Answer04 = "Brasil";
    q82.Answer05 = "Nárnia";
    q82.CorrectAnswer = 1;
    q82.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q82);

    var q83 = new Questao();
    q83.Question = "Quem desenvolveu a teoria da evolução?";
    q83.Answer01 = "Charles Darwin";
    q83.Answer02 = "Gregor Mendel";
    q83.Answer03 = "Isaac Newton";
    q83.Answer04 = "Marie Curie";
    q83.Answer05 = "Professor Xavier";
    q83.CorrectAnswer = 1;
    q83.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q83);

    var q84 = new Questao();
    q84.Question = "Qual é a cidade mais populosa do Brasil?";
    q84.Answer01 = "São Paulo";
    q84.Answer02 = "Rio de Janeiro";
    q84.Answer03 = "Belo Horizonte";
    q84.Answer04 = "Salvador";
    q84.Answer05 = "Mordor";
    q84.CorrectAnswer = 1;
    q84.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q84);

    var q85 = new Questao();
    q85.Question = "Qual é a fórmula química do gás carbônico?";
    q85.Answer01 = "CO2";
    q85.Answer02 = "O2";
    q85.Answer03 = "H2O";
    q85.Answer04 = "NaCl";
    q85.Answer05 = "Sprite";
    q85.CorrectAnswer = 1;
    q85.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q85);

    var q86 = new Questao();
    q86.Question = "Em que ano o homem pisou na Lua?";
    q86.Answer01 = "1969";
    q86.Answer02 = "1970";
    q86.Answer03 = "1965";
    q86.Answer04 = "1959";
    q86.Answer05 = "Ano de lançamento do Star Wars";
    q86.CorrectAnswer = 1;
    q86.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q86);

    var q87 = new Questao();
    q87.Question = "Quem foi o primeiro presidente dos Estados Unidos?";
    q87.Answer01 = "George Washington";
    q87.Answer02 = "Abraham Lincoln";
    q87.Answer03 = "Thomas Jefferson";
    q87.Answer04 = "John Adams";
    q87.Answer05 = "Capitão América";
    q87.CorrectAnswer = 1;
    q87.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q87);

    var q88 = new Questao();
    q88.Question = "Qual é o menor país do mundo?";
    q88.Answer01 = "Vaticano";
    q88.Answer02 = "Mônaco";
    q88.Answer03 = "Nauru";
    q88.Answer04 = "Malta";
    q88.Answer05 = "Ilha do Tesouro";
    q88.CorrectAnswer = 1;
    q88.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q88);

    var q89 = new Questao();
    q89.Question = "Quem pintou 'A Última Ceia'?";
    q89.Answer01 = "Leonardo da Vinci";
    q89.Answer02 = "Michelangelo";
    q89.Answer03 = "Raphael";
    q89.Answer04 = "Donatello";
    q89.Answer05 = "As Tartarugas Ninja";
    q89.CorrectAnswer = 1;
    q89.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q89);

    var q90 = new Questao();
    q90.Question = "Qual é a capital da Alemanha?";
    q90.Answer01 = "Berlim";
    q90.Answer02 = "Hamburgo";
    q90.Answer03 = "Munique";
    q90.Answer04 = "Frankfurt";
    q90.Answer05 = "Berlim Oriental";
    q90.CorrectAnswer = 1;
    q90.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q90);

    var q91 = new Questao();
    q91.Question = "Qual é a velocidade da luz no vácuo?";
    q91.Answer01 = "299.792.458 m/s";
    q91.Answer02 = "150.000.000 m/s";
    q91.Answer03 = "1.080.000 km/h";
    q91.Answer04 = "300.000 m/s";
    q91.Answer05 = "A velocidade de um Wi-Fi ruim";
    q91.CorrectAnswer = 1;
    q91.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q91);

    var q92 = new Questao();
    q92.Question = "Quem escreveu 'A Origem das Espécies'?";
    q92.Answer01 = "Charles Darwin";
    q92.Answer02 = "Isaac Newton";
    q92.Answer03 = "Stephen Hawking";
    q92.Answer04 = "Carl Sagan";
    q92.Answer05 = "Dr. Doolittle";
    q92.CorrectAnswer = 1;
    q92.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q92);

    var q93 = new Questao();
    q93.Question = "Qual é o país com maior área territorial?";
    q93.Answer01 = "Rússia";
    q93.Answer02 = "Canadá";
    q93.Answer03 = "China";
    q93.Answer04 = "Estados Unidos";
    q93.Answer05 = "Hogwarts";
    q93.CorrectAnswer = 1;
    q93.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q93);

    var q94 = new Questao();
    q94.Question = "Qual é a capital da Índia?";
    q94.Answer01 = "Nova Délhi";
    q94.Answer02 = "Mumbai";
    q94.Answer03 = "Calcutá";
    q94.Answer04 = "Chennai";
    q94.Answer05 = "Bollywood";
    q94.CorrectAnswer = 1;
    q94.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q94);

    var q95 = new Questao();
    q95.Question = "Quem foi o primeiro homem a viajar para o espaço?";
    q95.Answer01 = "Yuri Gagarin";
    q95.Answer02 = "Neil Armstrong";
    q95.Answer03 = "Buzz Aldrin";
    q95.Answer04 = "Alan Shepard";
    q95.Answer05 = "Han Solo";
    q95.CorrectAnswer = 1;
    q95.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q95);

    var q96 = new Questao();
    q96.Question = "Qual é o menor planeta do Sistema Solar?";
    q96.Answer01 = "Mercúrio";
    q96.Answer02 = "Plutão";
    q96.Answer03 = "Vênus";
    q96.Answer04 = "Marte";
    q96.Answer05 = "A Estrela da Morte";
    q96.CorrectAnswer = 1;
    q96.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q96);

    var q97 = new Questao();
    q97.Question = "Qual é o símbolo químico do ouro?";
    q97.Answer01 = "Au";
    q97.Answer02 = "Ag";
    q97.Answer03 = "Fe";
    q97.Answer04 = "Cu";
    q97.Answer05 = "Wakanda";
    q97.CorrectAnswer = 1;
    q97.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q97);

    var q98 = new Questao();
    q98.Question = "Em que ano ocorreu a Revolução Francesa?";
    q98.Answer01 = "1789";
    q98.Answer02 = "1799";
    q98.Answer03 = "1776";
    q98.Answer04 = "1804";
    q98.Answer05 = "No tempo das vacas voadoras";
    q98.CorrectAnswer = 1;
    q98.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q98);

    var q99 = new Questao();
    q99.Question = "Qual é a capital da Rússia?";
    q99.Answer01 = "Moscou";
    q99.Answer02 = "São Petersburgo";
    q99.Answer03 = "Kiev";
    q99.Answer04 = "Novosibirsk";
    q99.Answer05 = "Gotham City";
    q99.CorrectAnswer = 1;
    q99.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q99);

    var q100 = new Questao();
    q100.Question = "Quem foi o primeiro homem a pisar na Lua?";
    q100.Answer01 = "Neil Armstrong";
    q100.Answer02 = "Buzz Aldrin";
    q100.Answer03 = "Yuri Gagarin";
    q100.Answer04 = "Alan Shepard";
    q100.Answer05 = "Luke Skywalker";
    q100.CorrectAnswer = 1;
    q100.ConfigurarDesenho(labelQuestion, btnAnswer01, btnAnswer02, btnAnswer03, btnAnswer04, btnAnswer05);
    Listaquestoes.Add(q100);
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