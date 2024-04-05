namespace Poa;

public partial class MainPage : ContentPage
{
	principal atual;

	dogmae Mahaia = new dogmae();

	dogfilhote Bisnaguinho = new dogfilhote();

	dogpai Theodoro = new dogpai();

	public MainPage()
	{
    	InitializeComponent();

	  	atual = Theodoro;

		img.Source = atual.GetNomeDaImagem();
	
		progressoFome.Progress = atual.GetFome();
		progressoSede.Progress = atual.GetSede();
		progressoBrincar.Progress = atual.GetBrincar();
	}


	void AumentaBrincar(object sender, EventArgs args)
	{
		atual = Mahaia;
	}

	void AumentaSede(object sender, EventArgs args)
	{
		atual = Mahaia;
	}
	void AumentaFome(object sender, EventArgs args)
	{
		atual = Mahaia;
	}

	void TrocaPersonagem(object sender, EventArgs args)
	{
	   if(atual == Bisnaguinho) 
	   {
		atual = Mahaia;
	   }
	   else if (atual == Mahaia)
	   {
		atual = Theodoro;
	   }
	   else 
	   {
		atual = Bisnaguinho;
	   }
	   img.Source = atual.GetNomeDaImagem();
	}
}

