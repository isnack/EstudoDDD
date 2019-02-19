namespace Domain
{
    public  class Ligacao
    {
        public int origem { get; set; }
        public int destino { get; set; }
        public int tempo { get; set; }
        public string planoNome { get; set; }
        public double valorComPlano { get; set; }
        public double valorSemPlano { get; set; }

        public Ligacao(int origem, int destino, int tempo, string planoNome, double valorComPlano, double valorSemPlano)
        {
            this.origem = origem;
            this.destino = destino;
            this.tempo = tempo;
            this.planoNome = planoNome;
            this.valorComPlano = valorComPlano;
            this.valorSemPlano = valorSemPlano;
        }
    }
}
