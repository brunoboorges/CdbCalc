namespace CdbCalc.WebApi.Models
{
    public class CdbResponse
    {
        public decimal ValorBruto { get; set; }  // Valor final sem impostos
        public decimal ValorLiquido { get; set; } // Valor final com impostos
    }
}
