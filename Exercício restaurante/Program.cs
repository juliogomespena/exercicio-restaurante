//Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio.
//A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos.
//Os pedidos podem estar associados a uma mesa.

Cardapio cardapio = new();

//Adicionando pratos
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

cardapio.AdicionarPratosAoCardapio(prato01);
cardapio.AdicionarPratosAoCardapio(prato02);
cardapio.AdicionarPratosAoCardapio(prato03);

cardapio.ExibirCardapio();