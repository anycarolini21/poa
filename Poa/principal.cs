namespace Poa;

public class principal
{
    protected double Fome;
    public double Sede;
    public double Brincar;
    protected string nomeDaImagem;
    protected string NomedaImagemMorto;
    protected bool Morto;
     

        public string GetNomeDaImagem()
        {
            if (Morto)
            return NomedaImagemMorto;
            else
            return nomeDaImagem;
        }

        public void SetFome(double F)
        {
            if(Fome > 1)
                Fome = 1;
            else if (Fome <= 0)
                Fome = 0;
            else 
                Fome = F;

            if (Fome <= 0.1)
                Morto = true;
        }

        public double GetFome()
        {
            return Fome;
        }

        public void SetSede(double S)
        {
            if(Sede > 1)
                Sede = 1;
            else if (Sede <= 0)
                Sede = 0;
            else 
                Sede = S;

            if (Sede <= 0.1)
                Morto = true;
          
        }
        public double GetSede()
        {
            return Sede;
        }
        public void SetBrincar(double B)
        {
            if(Brincar > 1)
               Brincar = 1;
            else if (Brincar <= 0)
               Brincar = 0;
            else 
               Brincar = B;

            if (Brincar <= 0.1)
                Morto = true;
        }

        public double GetBrincar() 
        {
            return Brincar;
        }
        public bool GetMorto() 
        {
            return Morto;
        }


}