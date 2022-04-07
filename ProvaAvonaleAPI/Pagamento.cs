namespace ProvaAvonaleAPI
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int Valor { get; set;}
        public string Estado { get; set; } = string.Empty;
        public Cartao Cartao { get; set; }
    }
}
