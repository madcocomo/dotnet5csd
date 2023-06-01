using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperMarketAPI.Models
{
    [Table("item")]
    public class Item
    {
        [Key]
        public string? Barcode { get; set; }
        public string? Name { get; set; }
        public string? Unit { get; set; }
        public decimal Price { get; set; }
        public int Type { get; set; }
    }
}