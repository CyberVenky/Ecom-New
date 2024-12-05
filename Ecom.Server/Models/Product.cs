namespace Ecom.Server.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int? UnitStock { get; set; }     
        public byte[] ProductImagePath { get; set; }
        //public int CartId { get; set; }
        public int? CategoryId { get; set; }
        //public int OrderLineId { get; set; }
        //public int? PictureId { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual Category Category { get; set; }
        public virtual OrderLine OrderLine { get; set; }
        public virtual Picture Picture { get; set; }

    }
}