namespace TaxCalculator.API.Models
{
    public class PostalCodes
    {
        public int Id { get; set; }
        public string? PostalCode { get; set; }
        public TaxType TaxType { get; set; }
    }
}
