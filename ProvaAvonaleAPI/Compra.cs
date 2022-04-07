namespace ProvaAvonaleAPI
{
    public class Compra
    {
        public int Id { get; set; }
        public int Id_produto { get; set; }
        public int Qtd_comprada { get; set; }
        public Cartao Cartao { get; set; } 
    }
}
