// ScreenSound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";


void ExibirMensagemDeBoasVindas()
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
        case 1:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerida);
            break;
        case 2:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerida);
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



ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();