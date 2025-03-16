using System.ComponentModel.DataAnnotations;

namespace SpentSmart.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "0 >")]
        public decimal Value { get; set; }
        [Required(ErrorMessage ="can not empty")]
        public string? Description { get; set; }
    }
}
