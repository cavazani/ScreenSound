


class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

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




