using Modelos;
using Milhao;
namespace Ajudas;
public partial class Universitarios : IAjudas
{
    public override void RealizaAjuda(Questao questao)
    {
        var porcentagem = 100;

        for (int i = 0; i < 5; i++)
        {
            int numRandomico = 0;

            if(porcentagem > 0)
            {
                numRandomico = Random.Shared.Next(0, porcentagem);
                porcentagem -= numRandomico; 

                switch(i)
                {
                    case 0:
                        btnAnswer01.Text += ":" + numRandomico.ToString() + "%";
                        break;
                    
                    case 1:
                        btnAnswer02.Text += ":" + numRandomico.ToString() + "%";
                        break;
                    
                    case 2:
                        btnAnswer03.Text += ":" + numRandomico.ToString() + "%";
                        break;
                    
                    case 3:
                        btnAnswer04.Text += ":" + numRandomico.ToString() + "%";
                        break;

                    case 4:
                        btnAnswer05.Text += ":" + numRandomico.ToString() + "%";
                        break;
                }
            }
        }
    }
}