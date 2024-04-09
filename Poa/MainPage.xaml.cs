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

		var timer = Application.Current.Dispatcher.CreateTimer();
			timer.Interval =
			TimeSpan.FromSeconds(5);
			timer.Tick += (s,e) =>
			PassouTempo();
			timer.Start();
	}

	void AtualizaPersonagem()
	{
		progressoFome.Progress= atual.GetFome();
		progressoSede.Progress= atual.GetSede();
		progressoBrincar.Progress= atual.GetBrincar();
	}


	void AumentaBrincar(object sender, EventArgs args)
	{
		atual.SetBrincar(atual.GetBrincar()+0.1);
		AtualizaPersonagem();
	}
	void AumentaSede(object sender, EventArgs args)
	{
		atual.SetSede(atual.GetSede()+0.1);
		AtualizaPersonagem();
	}
	void AumentaFome(object sender, EventArgs args)
	{
		atual.SetFome(atual.GetFome()+0.1);
		AtualizaPersonagem();
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

	   progressoFome.Progress = atual.GetFome();
       progressoSede.Progress = atual.GetSede();
	   progressoBrincar.Progress = atual.GetBrincar();
	
	}

		 void PassouTempo()
		 {
			atual.SetSede(atual.GetSede()-0.1);
			atual.SetFome(atual.GetFome()-0.1);
			atual.SetBrincar(atual.GetBrincar()-0.1);
			AtualizaPersonagem();
		 }

}

