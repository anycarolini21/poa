namespace Poa;

public class principal
{
    protected double Fome;
    public double Sede;
    public double Brincar;
    protected string nomeDaImagem;
    protected string NomedaImagemMorto;
    protected bool morto;
     

        public string GetNomeDaImagem()
        {
            if (morto)
            return NomedaImagemMorto;
            else
            return nomeDaImagem;
        }

        public void SetFome(double F)
        {
            if(Fome > 1)
            Fome = 1;
            else if (Fome > 0)
            {
            Fome = 0;
            morto = true;
            }
            else 
            Fome = F;
          }

        public double GetFome()
        {
            return Fome;
        }

        public void SetSede(double S)
        {
            Sede=S;
        }
        public double GetSede()
        {
            return Sede;
        }
        public void SetBrincar(double B)
        {
            Brincar=B;
        }

        public double GetBrincar() 
        {
            return Brincar;
        }


}