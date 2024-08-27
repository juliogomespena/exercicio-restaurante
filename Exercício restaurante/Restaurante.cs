class Restaurante
{

    //Iniciando instância do cardápio que vai receber os valores do Program.cs
    private Cardapio Cardapio { get; set; } = new();
    //Lista de pratos que vão ser adicionados ao cardápio
    List<Pratos> pratosParaAdd = new();
    List<Mesas> mesas = new();

    public void AdicionarPratosAoCardapio()
    {

        //Para cada prato adicionado à lista de pratos
        foreach (Pratos pratos in pratosParaAdd)
        {

            //Se prato estiver disponível
            if (pratos.Disponivel)
            {

                //Registra prato no cardápio
                Cardapio.RegistrarPratosNoCardapio(pratos);

            }

        }

    }

    public void ExibirCardapio()
    {

        //Método que exibe o cardápio
        Cardapio.GerarCardapio();

    }

    public void CriarPratos()
    {

        //Simula entrada
        Pratos prato01 = new()
        {

            Id = 1,
            NomeDoPrato = "Strogonoff de carne",
            DescricaoDoPrato = "Cremoso strogonoff de file mignon",
            Preco = 39.99m,
            Disponivel = true

        };

        Pratos prato02 = new()
        {

            Id = 2,
            NomeDoPrato = "Macarrão a bolonhesa",
            DescricaoDoPrato = "Macarrão grano duro com molho a bolonhesa",
            Preco = 34.99m,
            Disponivel = true

        };

        Pratos prato03 = new()
        {

            Id = 3,
            NomeDoPrato = "Contra filé empanado",
            DescricaoDoPrato = "Contra filé empanado na farinha de rosca",
            Preco = 41.99m,
            Disponivel = true

        };

        pratosParaAdd.Add(prato01);
        pratosParaAdd.Add(prato02);
        pratosParaAdd.Add(prato03);

    }

    public void CriarMesas(int qtd)
    {

        for (int i = 1; i <= qtd; i++)
        {
            
            //Para efeitos de estudos, tornar a disponibilidade da mesa aleatória.
            Random random = new Random();
            if (random.Next(0, 2) == 0)
            {

                Mesas mesaParaAdd = new()
                {

                    NumeroDaMesa = i,
                    Mensagem = $"Mesa {i} está disponível.",
                    Reservada = false

                };
                mesas.Add(mesaParaAdd);
                

            }
            else 
            {

                Mesas mesaParaAdd = new()
                {

                    NumeroDaMesa = i,
                    Mensagem = $"Mesa {i} está reservada.",
                    Reservada = true

                };
                mesas.Add(mesaParaAdd);

            }


        }

    }

    public void ExibirMesas()
    {

        foreach (Mesas mesa in mesas)
        {

            Console.WriteLine($"Número da mesa: {mesa.NumeroDaMesa}\n{mesa.Mensagem}\n\n");

        }

    }

}