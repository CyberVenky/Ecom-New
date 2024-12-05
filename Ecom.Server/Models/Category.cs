namespace Ecom.Server.Models
{
    public class Category
    {
        public int Id;
        public required string Categoriesname;
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public virtual ICollection<SubCategory> SubCategories { get; set; } = new HashSet<SubCategory>();
        

    }
}
