namespace Poa;

public partial class MainPage : ContentPage
{
	principal atual;

	dogmae Mahaia = new dogmae();

	dogfilho Bisnaguinho = new dogfilho();

	dogpai Theodoro = new dogpai();

	public MainPage()
	{
    	InitializeComponent();

	  	atual = Bisnaguinho;

		imgPersonagem.Source = atual.GetNomeDaImagem();
		progressBarFome.Progress = atual.GetFome();
	}


	void QuandoApertarNoBotaoTrocar(object sender, EventArgs args)
	{
		atual = Mahaia;
	}
}
