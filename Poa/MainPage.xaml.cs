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

	  	atual = Bisnaguinho;

		img.Source = atual.GetNomeDaImagem();
		progressBarFome.Progress = atual.GetFome();
	}


	void QuandoApertarNoBotaoTrocar(object sender, EventArgs args)
	{
		atual = Mahaia;
	}
}
