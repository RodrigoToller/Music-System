








string mensagemDeBoasVindas = ("Seja bem vindo ao" + Environment.NewLine + "\r\n█▀ █▀█ █░█ █▄░█ █▀▄   █▀▀ █ █▀█ █▀▀ █░░ █▀▀\r\n▄█ █▄█ █▄█ █░▀█ █▄▀   █▄▄ █ █▀▄ █▄▄ █▄▄ ██▄" + Environment.NewLine);


List<string> musicas = new List<string>();



HomeSystem();






 void HomeSystem()
{
    Console.Clear();
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("Digite o número correspondente ao que você deseja fazer:" + Environment.NewLine);
    
    Console.WriteLine("1 - Registrar Musicas");
    Console.WriteLine("2 - Acessar Musicas");
    Console.WriteLine("3 - Acessar Playlists");
    Console.WriteLine("4 - Acessar Artistas");
    Console.WriteLine("5 - Acessar Gêneros");
    Console.WriteLine("6 - Sair" + Environment.NewLine);

    string entradaDoUsuarioString = Console.ReadLine();
    int entradaDoUsuario = int.Parse(entradaDoUsuarioString);

    switch (entradaDoUsuario)
    {

        case 1:
        RegistrarMusicaPainel();
        Console.WriteLine("Acessando Registrar Musicas...");
        break;
        case 2:
        VisualizarMusicas();
        break;
        case 3:
        Console.WriteLine("Acessando Playlists...");
        break;
        case 4:
        Console.WriteLine("Acessando Artistas...");
        break;
        case 5:
        Console.WriteLine("Acessando Gêneros...");
        break;
        case 6:
        Console.WriteLine("Saindo...");
        break;
        default:
        Console.WriteLine("Opção inválida");
        break;
    }
}



void VisualizarMusicas()
{
    Console.Clear();
    Console.WriteLine("Acessando Musicas...");
    foreach (string musica in musicas)
    {
        Console.WriteLine(Environment.NewLine + "##########################" + Environment.NewLine);
        Console.WriteLine(musica + Environment.NewLine);
        Console.WriteLine("##########################");
    }
    Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
    Console.ReadLine();
    HomeSystem();
}

static void RegistrarMusica(List<string> musicas, string nomeDaMusica)
{ 
    musicas.Add(nomeDaMusica);
    Console.WriteLine("Música registrada com sucesso!");
    Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
    Console.ReadLine();
    Console.Clear();
}
void RegistrarMusicaPainel()
{

    Console.Clear();
    Console.WriteLine("Digite o nome da música:");
    string nomeDaMusica = Console.ReadLine();

    if(nomeDaMusica == null)
    {
        Console.WriteLine("Nome da música inválido");
        Console.WriteLine("Digite qualquer tecla para voltar registrar novamente");
        Console.ReadLine();
        Console.Clear();
        HomeSystem();
        return;
    }

    RegistrarMusica(musicas, nomeDaMusica);
    Console.Clear();
    Console.WriteLine("Digite 1 para cadastrar outra musica");
    Console.WriteLine("Digite qualquer outra tecla para voltar ao menu principal");

    string entradaDoUsuarioString = Console.ReadLine();

    if (entradaDoUsuarioString == "1")
    {
        RegistrarMusicaPainel();
    }
    else
    {
        HomeSystem();
    }

}
