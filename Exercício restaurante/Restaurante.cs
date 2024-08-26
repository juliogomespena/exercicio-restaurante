class Restaurante
{

    //Iniciando instância do cardápio que vai receber os valores do Program.cs
    private Cardapio Cardapio { get; set; } = new();

    public void AdicionarPratosAoCardapio(Pratos prato)
    {

        //Método que registra prato no cardápio
        Cardapio.RegistrarPratosNoCardapio(prato);

    }

    public void ExibirCardapio()
    {

        //Método que exibe o cardápio
        Cardapio.GerarCardapio();

    }

}