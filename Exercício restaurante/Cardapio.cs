class Cardapio
{
    //Cria uma lista de pratos dentro da classe cardápio
    List<Pratos> cardapio { get; set; } = new();

    public void RegistrarPratosNoCardapio(Pratos prato)
    {

        //Adiciona um elemento da classe Pratos a lista de elementos Pratos 'cardapio'
        cardapio.Add(prato);

    }

    public void GerarCardapio()
    {

        Console.WriteLine("Cardápio ->\n");

        //Ao chamar a função no Restaurante.cs da instancia que foi assumida pela instancia do Program.cs
        //Os valores já são passados como os valores padrões da classe.

        foreach (Pratos prato in cardapio)
        {
        
                Console.WriteLine($"{prato.NomeDoPrato}\n{prato.DescricaoDoPrato}\nR$: {prato.Preco}\n");

        }

    }

}