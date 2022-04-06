namespace ProvaAvonaleAPI
{ 
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Valor_unitario { get; set; } 
        public int Qtde_estoque { get; set; }
    }
}
