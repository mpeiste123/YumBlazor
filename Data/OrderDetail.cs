using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Data
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderHeaderId { get; set; }
        //Navigation property
        //We do not need a foreign key reference
        // because we only ned an Id
        public OrderHeader OrderHeader {get;set;}
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string ProductName { get; set; }
    }
}
