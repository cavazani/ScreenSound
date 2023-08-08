//// ScreenSound
//string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
////List<string> listaDasBandas = new List<string>()
////{
////    "U2",
////    "Pearl Jam",
////    "Nirvana",
////};

//Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string,List<int>>();
//bandasRegistradas.Add("Link Park", new List<int> {10,8,5,6});
//bandasRegistradas.Add("Pearl Jam", new List<int> { 10, 10, 10, 10 });
//bandasRegistradas.Add("Korn", new List<int> { 7, 3, 1});


//void ExibirLogo()
//{
//    Console.WriteLine(@"
    
//    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
//    ");
//    Console.WriteLine(mensagemDeBoasVindas);
//}


//void ExibirOpcoesDoMenu()
//{
//    Console.WriteLine("\nDigite 1 para registrar uma banda");
//    Console.WriteLine("Digite 2 para mostrar todas as bandas");
//    Console.WriteLine("Digite 3 para avaliar uma banda");
//    Console.WriteLine("Digite 4 para aexibir a média de uma banda");
//    Console.WriteLine("Digite -1 para sair");

//    Console.Write("\nDigite a sua opção: ");
//    string opcaoEscolhida = Console.ReadLine()!; // ! não iremos trabalhar com valores null
//    int opcaoEscolhidaNumerida = int.Parse(opcaoEscolhida); //Converter a opcaoEscolhida de string para Inteiro(int)

//    //Exemplo de uma forma utilizando If Else
//    //if (opcaoEscolhidaNumerida == 1)
//    //{
//    //    Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
//    //}
//    //else if (opcaoEscolhidaNumerida == 2)
//    //{
//    //    Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
//    //}

//    switch (opcaoEscolhidaNumerida)
//    {
//        case 1:RegistrarBanda();
//            break;
//        case 2:MostrarBandasRegistradas();
//            break;
//        case 3: AvaliarUmaBanda();
//            break;
//        case 4:ExibirMedia();
//            break;
//        case -1:
//            Console.WriteLine("Tchau Tchau :) ");
//            break;
//        default:
//            Console.WriteLine("Opção Inválida");
//            break;
//    }
//}

//void RegistrarBanda()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Registro de bandas");
//    Console.Write("Digite o nome da banda que deseja registrar: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    //listaDasBandas.Add(nomeDaBanda); //.Add Adiciona o nomeDaBanda na lista de string vazia
//    bandasRegistradas.Add(nomeDaBanda, new List<int>());
//    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
//    Thread.Sleep(2000);
//    Console.Clear();
//    ExibirOpcoesDoMenu();
//}

//void MostrarBandasRegistradas()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

//    //Utilizando FOR Exemplo
//    //for(int i = 0; i < listaDasBandas.Count; i++)
//    //{
//    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
//    //}

//    //foreach (string banda in listaDasBandas)
//    //{
//    //    Console.WriteLine($"Banda: {banda}");
//    //}

//    foreach (string banda in bandasRegistradas.Keys)
//    {
//        Console.WriteLine($"Banda: {banda}");
//    }

//    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
//    Console.ReadKey();
//    Console.Clear();
//    ExibirOpcoesDoMenu();
//}

//void ExibirTituloDaOpcao(string titulo)
//{
//    int quantidadeDeLetras = titulo.Length;
//    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
//    Console.WriteLine(asteriscos);
//    Console.WriteLine(titulo);
//    Console.WriteLine(asteriscos);
//}

//void AvaliarUmaBanda()
//{
//    //digite qual a banda deseja avaliar
//    //se a banda existir no dicionario > atribuir uma nota
//    //senão, volta ao menu principal

//    Console.Clear();
//    ExibirTituloDaOpcao("Avaliar banda");
//    Console.Write("Digite o nome da banda que deseja avaliar: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    if (bandasRegistradas.ContainsKey(nomeDaBanda)) //.ContainsKey
//    {
//        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
//        int nota = int.Parse(Console.ReadLine()!);
//        bandasRegistradas[nomeDaBanda].Add(nota);
//        Console.WriteLine($"\nA nota {nota} foi regitrada com sucesso para a banda {nomeDaBanda}");
//        Thread.Sleep(2000);
//        Console.Clear();
//        ExibirOpcoesDoMenu();
//    }
//    else
//    {
//        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
//        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesDoMenu();
//    }
//}

//void ExibirMedia()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Exibir média da banda");
//    Console.Write("Digite o nome da banda que deseja exibir a média ");
//    string nomeDaBanda = Console.ReadLine()!;
//    if (bandasRegistradas.ContainsKey(nomeDaBanda)) //.ContainsKey
//    {
//        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
//        Console.WriteLine($"\nA média das notas da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
//        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesDoMenu();
//        //Assim tbm funciona o calculo da média
//        // double media = bandasRegistradas[nomeDaBanda].Average();
//        //Console.WriteLine($"\nA média das notas da banda {nomeDaBanda} é {media} ")
//        //;
//        Thread.Sleep(2000);
//        Console.Clear();
//        ExibirOpcoesDoMenu();
//    }
//    else
//    {
//        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
//        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesDoMenu();
//    }
//}

//ExibirLogo();
//ExibirOpcoesDoMenu();



//Utilizando Orientação a Objetos

Musica musica1 = new Musica();
musica1.Nome = "Black";
musica1.Artista = "Pearl Jam";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

//Chamando metodo da classe MUSICA
musica1.ExibirFichaTecnica();

Musica musica2 = new Musica();
musica2.Nome = "One Of Us";
musica2.Artista = "Joan Osborne";
musica2.Duracao = 353;
musica2.Disponivel = false;
Console.WriteLine(musica2.Disponivel);

musica2.ExibirFichaTecnica();

//Exemplo com interpolação
//Console.WriteLine($"Nome da música: {musica2.nome}");
//Console.WriteLine($"Nome do artista: {musica2.artista}");