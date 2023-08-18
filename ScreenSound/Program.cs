
using ScreenSound;
using ScreenSound.Modelos;

// ScreenSound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string>()
//{
//    "U2",
//    "Pearl Jam",
//    "Nirvana",
//};

Banda ira = new Banda("Ira!");
Banda beatles = new Banda("The Beatles");

//ira.AdicionarNota(10);


Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);


void ExibirLogo() {
    Console.WriteLine(@"

    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}


void ExibirOpcoesDoMenu() {
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para aexibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; // ! não iremos trabalhar com valores null
    int opcaoEscolhidaNumerida = int.Parse(opcaoEscolhida); //Converter a opcaoEscolhida de string para Inteiro(int)

    //Exemplo de uma forma utilizando If Else
    //if (opcaoEscolhidaNumerida == 1)
    //{
    //    Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    //}
    //else if (opcaoEscolhidaNumerida == 2)
    //{
    //    Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    //}

    switch (opcaoEscolhidaNumerida) {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Tchau Tchau :) ");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

void RegistrarBanda() {
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //listaDasBandas.Add(nomeDaBanda); //.Add Adiciona o nomeDaBanda na lista de string vazia
    Banda banda = new Banda(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, banda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas() {
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    //Utilizando FOR Exemplo
    //for(int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    //foreach (string banda in listaDasBandas)
    //{
    //    Console.WriteLine($"Banda: {banda}");
    //}

    foreach (string banda in bandasRegistradas.Keys) {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}


void RegistrarAlbum() 
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine();
    Console.Write("Agora digite o titulo do album: ");
    string tituloAlbum = Console.ReadLine();

    Console.WriteLine($"O Album {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo) {
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

void AvaliarUmaBanda() {
    //digite qual a banda deseja avaliar
    //se a banda existir no dicionario > atribuir uma nota
    //senão, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda)) //.ContainsKey
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        banda.AdicionarNota(nota);
        //bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi regitrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMedia() {
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja exibir a média ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda)) //.ContainsKey
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média das notas da banda {nomeDaBanda} é {banda.Media}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
        //Assim tbm funciona o calculo da média
        // double media = bandasRegistradas[nomeDaBanda].Average();
        //Console.WriteLine($"\nA média das notas da banda {nomeDaBanda} é {media} ")
        //;
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirLogo();
ExibirOpcoesDoMenu();



//****************Utilizando Orientação a Objetos****************************

//Musica musica1 = new Musica();
//musica1.Nome = "Black";
//musica1.Artista = "Pearl Jam";
//musica1.Duracao = 273;
//musica1.Disponivel = true;
//Console.WriteLine(musica1.Disponivel);

////Chamando metodo da classe MUSICA
//musica1.ExibirFichaTecnica();

//Musica musica2 = new Musica();
//musica2.Nome = "One Of Us";
//musica2.Artista = "Joan Osborne";
//musica2.Duracao = 353;
//musica2.Disponivel = false;
//Console.WriteLine(musica2.Disponivel);

//musica2.ExibirFichaTecnica();

////Exemplo com interpolação
//Console.WriteLine($"Nome da música: {musica2.nome}");
//Console.WriteLine($"Nome do artista: {musica2.artista}");


//*****Utilizando Class Album***


//using ScreenSound;
//using ScreenSound.Modelos;

//Banda queen = new Banda("Queen");

//Album albumDoQueen = new Album("A night at the opera");


//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true
//};


//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = false
//};

//Console.WriteLine("##################################################");
//Console.WriteLine("                                                   ");
//Episodio ep1 = new(1, "Tecnicas de facilitação", 45);
//ep1.AdicionarConvidados("Maria");
//ep1.AdicionarConvidados("Marcelo");
//Console.WriteLine(ep1.Resumo);

//Episodio ep2 = new(2, "Falando sobre programção", 355);
//ep2.AdicionarConvidados("Gabriel");
//ep2.AdicionarConvidados("Henrique");
//ep2.AdicionarConvidados("Flavia");
//Console.WriteLine(ep1.Resumo);

//Podcast podcast = new("Podcast especial","Daniel");
//podcast.AdicionarEpisodio(ep1);
//podcast.AdicionarEpisodio(ep2);
//podcast.ExibirDetalhes();

//Console.WriteLine("##################################################");
//Console.WriteLine("                                                   ");


//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.ExibirMusicasDoAlbum();

//queen.AdicionarAlbum(albumDoQueen);
//queen.ExibirDiscografia();