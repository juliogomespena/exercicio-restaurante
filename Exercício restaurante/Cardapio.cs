class Cardapio
{
    //Cria uma lista de pratos dentro da classe cardápio
    List<Pratos> cardapio { get; set; } = new();

    public void AdicionarPratosAoCardapio(Pratos prato)
    {

        cardapio.Add(prato);

    }

    public void ExibirCardapio()
    {

        foreach (Pratos pratos in cardapio)
        {
            
            if ( pratos.Disponivel == true)
            {
                Console.WriteLine("Cardápio ->");
                Console.WriteLine($"{pratos.NomeDoPrato}\n{pratos.DescricaoDoPrato}\nR$: {pratos.Preco}\n\n");
            }

        }

    }

}