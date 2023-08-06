// ScreenSound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string>()
{
    "U2",
    "Pearl Jam",
    "Nirvana",
};


void ExibirLogo()
{
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


void ExibirOpcoesDoMenu()
{
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

    switch (opcaoEscolhidaNumerida)
    {
        case 1:RegistrarBanda();
            break;
        case 2:MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerida);
            break;
        case 4:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerida);
            break;
        case -1:
            Console.WriteLine("Tchau Tchau :) ");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda); //.Add Adiciona o nomeDaBanda na lista de string vazia
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    //Utilizando FOR Exemplo
    //for(int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}


ExibirLogo();
ExibirOpcoesDoMenu();