namespace TaxCalculator.API.Models
{
    public class ProgressiveTax
    {
        public int Id { get; set; }
        public int TaxRate { get; set; }
        public decimal FromAmount { get; set; }
        public decimal ToAmount { get; set; }
    }
}
