namespace Poa;

public class principal
{
    protected double Fome;
    public double Sede;
    public double Brincar;
    protected string nomeDaImagem;

        public string GetNomeDaImagem()
        {
            return nomeDaImagem;
        }

        public void SetFome(double F)
        {
            Fome=F;
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