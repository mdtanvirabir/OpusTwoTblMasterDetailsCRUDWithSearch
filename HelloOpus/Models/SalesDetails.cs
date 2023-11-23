using System.ComponentModel.DataAnnotations;

namespace HelloOpus.Models
{
    public class SalesDetails
    {
        public int SalesDetailsId { get; set; }
        [Required, Display(Name = "Product Code")]
        public string ProductCode { get; set; }
        [Required, Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int SalesMasterId { get; set; }
        public virtual SalesMaster SalesMaster { get; set; }

    }
}
