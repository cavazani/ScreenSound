


class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    //Modelo construindo o valor que quer atribuir a essa propriedade só GET
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";

    //exemplo da estrutura acima menos utilizada
    //public string DescricaoResumida // Utilizar somente leitura GET
    //{
    //    get 
    //    {
    //        return $"A música {Nome} pertence a banda {Artista}";
    //    }
    
    //}


    //Podemos criar comportamentos para classe, metodos

    //Exemplo Padrao antigo Escrita - Metodo void não retorna nada mas outros metodos de outras classes tera acesso
    //public void EscreveDisponivel(bool value)
    //{
    //    disponivel = value;
    //}

    ////Exemplo Padrao antigo Leitura - Metodo para retornar meu bool disponivel
    //public bool LeDisponivel()
    //{
    //    return disponivel;
    //}

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }




}




