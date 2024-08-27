using System.IO;

class Restaurante
{

    //Iniciando instância do cardápio que vai receber os valores do Program.cs
    private Cardapio Cardapio { get; set; } = new();

    //Lista de pratos que vão ser adicionados ao cardápio
    List<Pratos> PratosParaAdd { get; set; } = new();

    //Lista de mesas disponíveis
    List<Mesas> Mesas { get; set; } = new();

    //Lista de pedidos feitos
    List<Pedidos> ListaDePedidos { get; set; } = new();

    private int contadorIdPedido = 0;

    public void AdicionarPratosAoCardapio()
    {

        //Para cada prato adicionado à lista de pratos
        foreach (Pratos pratos in PratosParaAdd)
        {

            //Se prato estiver disponível
            if (pratos.Disponivel)
            {

                //Registra prato no cardápio
                Cardapio.cardapio.Add(pratos);

            }

        }

    }

    public void ExibirCardapio()
    {

        Console.WriteLine("Cardápio ->\n");

        foreach (Pratos prato in Cardapio.cardapio)
        {

            Console.WriteLine($"{prato.NomeDoPrato}\n{prato.DescricaoDoPrato}\nR$: {prato.Preco}\n");

        }

    }

    public void CriarPratos()
    {

        //Simula entrada
        Pratos prato01 = new()
        {

            IdPrato = 1,
            NomeDoPrato = "Strogonoff de carne",
            DescricaoDoPrato = "Cremoso strogonoff de file mignon",
            Preco = 39.99m,
            Disponivel = true

        };

        Pratos prato02 = new()
        {

            IdPrato = 2,
            NomeDoPrato = "Macarrão a bolonhesa",
            DescricaoDoPrato = "Macarrão grano duro com molho a bolonhesa",
            Preco = 34.99m,
            Disponivel = true

        };

        Pratos prato03 = new()
        {

            IdPrato = 3,
            NomeDoPrato = "Contra filé empanado",
            DescricaoDoPrato = "Contra filé empanado na farinha de rosca",
            Preco = 41.99m,
            Disponivel = true

        };

        PratosParaAdd.Add(prato01);
        PratosParaAdd.Add(prato02);
        PratosParaAdd.Add(prato03);

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
                Mesas.Add(mesaParaAdd);
                

            }
            else 
            {

                Mesas mesaParaAdd = new()
                {

                    NumeroDaMesa = i,
                    Mensagem = $"Mesa {i} está reservada.",
                    Reservada = true

                };
                Mesas.Add(mesaParaAdd);

            }


        }

    }

    public void ExibirMesas()
    {

        foreach (Mesas mesa in Mesas)
        {

            Console.WriteLine($"Número da mesa: {mesa.NumeroDaMesa}\n{mesa.Mensagem}\n\n");

        }

    }

    public void CriarPedido(int numeroMesa, List<int> idPratosPedidos)
    {

        //Checa se número da mesa é válido
        if (numeroMesa <= Mesas.Count)
        {

            //Instância de Pedido criada para armazenar valores a serem adicionado a lista
            Pedidos pedido = new();

            //Gera número de ID
            contadorIdPedido++;
            pedido.IdDoPedido = contadorIdPedido;

            //Atribui status ao prato
            pedido.Status = "Em preparação.";

            //Percorre as mesas criadas
            foreach (Mesas mesa in Mesas)
            {

                //Se o número da mesa passado como parametro for igual a uma mesa criada
                if (mesa.NumeroDaMesa == numeroMesa)
                {

                    //Atribui mesa criada á mesaDoPedido
                    pedido.MesaDoPedido = mesa;

                }

            }

            //Percorre a lista de ids de pratos passados como parametro
            for (int i = 0; i < idPratosPedidos.Count; i++)
            {

                //Percorre a lista de pratos no cardapio
                foreach (Pratos pr in Cardapio.cardapio)
                {

                    //Se o número de Id do prato passado como parametro for igual a de um prato do cardápio
                    if (pr.IdPrato == idPratosPedidos[i])
                    {

                        //Adiciona prato ao pedido
                        pedido.PratosDoPedido.Add(pr);

                    }

                }

            }

            ListaDePedidos.Add(pedido);
        }
        else
        {

            Console.WriteLine("Mesa inválida!");

        }

    }

    public void ExibirPedidos()
    {

        foreach (Pedidos ped in ListaDePedidos)
        {

            Console.WriteLine($"Id do pedido: {ped.IdDoPedido}");
            Console.WriteLine($"Mesa do pedido: {ped.MesaDoPedido.NumeroDaMesa}");
            Console.WriteLine($"Status: {ped.Status}");
            Console.Write($"Pratos: ");

            if (ped.PratosDoPedido.Count == 1) Console.WriteLine($"{ped.PratosDoPedido[0].NomeDoPrato}");
            else
            {
                for (int i = 0; i < ped.PratosDoPedido.Count; i++)
                {

                    Console.Write($"{ped.PratosDoPedido[i].NomeDoPrato} || ");


                }

            }

            Console.WriteLine("\n");

        }

    }

}