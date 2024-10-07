using Modelos;
using Milhao;


public abstract class IAjudas
{
    protected Button btnAnswer01;
    protected Button btnAnswer02;
    protected Button btnAnswer03;
    protected Button btnAnswer04;
    protected Button btnAnswer05;
    protected Frame HelpFrame;
    
    public void  ConfigurarDesenho(Button btnAnswer01, Button btnAnswer02, Button btnAnswer03, Button btnAnswer04, Button btnAnswer05 )
    {
        this.btnAnswer01 = btnAnswer01;
        this.btnAnswer02 = btnAnswer02;
        this.btnAnswer03 = btnAnswer03;
        this.btnAnswer04 = btnAnswer04;
        this.btnAnswer05 = btnAnswer05;
    }
    public void ConfigurarDesenho(Frame HelpFrame)
    {
        this.HelpFrame = HelpFrame;
    }
    public abstract void RealizaAjuda(Questao questao);
}