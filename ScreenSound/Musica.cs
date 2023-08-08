


class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel;

    //Podemos criar comportamentos para classe, metodos

    //Escrita - Metodo void não retorna nada mas outros metodos de outras classes tera acesso
    public void EscreveDisponivel(bool value)
    {
        disponivel = value;
    }

    //Leitura - Metodo para retornar meu bool disponivel
    public bool LeDisponivel()
    {
        return disponivel;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }




}




