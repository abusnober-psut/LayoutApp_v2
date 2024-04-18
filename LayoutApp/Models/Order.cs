using System.ComponentModel.DataAnnotations;
namespace LayoutApp.Models
{
    public class Order
    {
        [Required(ErrorMessage = "Order Id cannot be Empty")]
        [RegularExpression("[0-9]{4}", ErrorMessage = "Order Id should be 4 digits length")]
        public int OrderId { get; set; }

        [Required]
        [RegularExpression(@"(AMM|ZAQ|IRB)\d{3}", ErrorMessage = "Order Key have to be started with zone code")]
        public string OrderKey { get; set; }

        [Required]
        [RegularExpression(@"00962 (78|77|79) \d{4} \d{3}")]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(1, 10)]
        public int Quantity { get; set; }

        [Required]
        [Range(0.5, 100, ErrorMessage ="Price cannot be negative value")]
        public double Price{get; set;}

        [Length(0, 100)]
        public string Destination { get; set; }

    }

    public enum Location
    {
        Jubaiha,
        Khalda,
        Jamea,
        [Display(Name="Amman North") ] AN

    }
}
