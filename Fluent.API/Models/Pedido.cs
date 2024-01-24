namespace Fluent.API.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int Quantidade { get; set; }
        public int Preco { get; set; }
        public int? idUsuario { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
