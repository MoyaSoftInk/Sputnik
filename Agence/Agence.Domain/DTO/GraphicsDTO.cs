namespace Agence.Domain.DTO
{
    public class GraphicsDTO
    {
        public GraphicsDTO() { }
        public GraphicsDTO(string coUsuario, string noUsuario, decimal receita, decimal promCustoFixo)
        {
            this.CoUsuario = coUsuario;
            this.NoUsuario = noUsuario;
            this.Receita = receita;
            this.PromCustoFixo = promCustoFixo;
        }

        public string CoUsuario;
        public string NoUsuario;
        public decimal Receita;
        public decimal PromCustoFixo;
        public decimal PercentageReceitaLiquida;
    }
}
