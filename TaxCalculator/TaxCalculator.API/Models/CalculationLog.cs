namespace TaxCalculator.API.Models
{
    public class CalculationLog
    {
        public int Id { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTime Date { get; set; }
    }
}
