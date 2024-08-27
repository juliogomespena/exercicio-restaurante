//Os pedidos podem estar associados a uma mesa.

class Pedidos
{

    public int IdDoPedido { get; set; }
    public Mesas MesaDoPedido { get; set; }
    public string Status { get; set; }
    public List<Pratos> PratosDoPedido { get; set; } = new();

}