﻿namespace ProvaAvonaleAPI
{
    public class Cartao
    {
        public int Id { get; set; }
        public string Titular { get; set; } = string.Empty;
        public string numero { get; set; } = string.Empty;
        public string Data_expiracao { get; set; } = string.Empty;
        public string Bandeira { get; set; } = string.Empty;
        public string Cvv { get; set; } = string.Empty;
    }
}
