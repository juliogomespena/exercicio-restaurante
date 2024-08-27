//Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio.
//A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos.
//Os pedidos podem estar associados a uma mesa.

//Iniciando instância do restaurante
Restaurante restaurante = new();

//Criando pratos
restaurante.CriarPratos();

//Adiciona pratos criados ao cardápio do restaurante
restaurante.AdicionarPratosAoCardapio();

//Cria mesas do restaurante
restaurante.CriarMesas(3);

//Exibe o cardapio
restaurante.ExibirCardapio();

Console.WriteLine();

//Exibe mesas
restaurante.ExibirMesas();

//Cria pedido para a mesa 01
restaurante.CriarPedido(3, [1, 1, 0]);

//Cria pedido para a mesa 02
restaurante.CriarPedido(2, [2]);

//Exibe pedidos
restaurante.ExibirPedidos();

