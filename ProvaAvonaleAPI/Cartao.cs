namespace ProvaAvonaleAPI
{
    public class Cartao
    {
        public int Id { get; set; }
        public string Titiular { get; set; } = string.Empty;
        public string Data_expiracao { get; set; } = string.Empty;
        public string Bandeira { get; set; } = string.Empty;
        public int Cvv { get; set; }
    }
}
