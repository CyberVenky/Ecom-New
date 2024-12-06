using Ecom.Server.Data;
using Ecom.Server.Models;
using Ecom.Server.Services.Infrastructure;

namespace Ecom.Server.Services.Repository
{
    public class SubCategoryItemRepository(ApplicationDbContext context) : ISubCategory
    {
        private ApplicationDbContext _context = context;

        public int Count()
        {
            return _context.SubCategories.Count();
        }

        public void Delete(int id)
        {
            var subcategory = _context.SubCategories.FirstOrDefault(c => c.Id == id);
            if (subcategory != null)
            {
                _context.SubCategories.Remove(subcategory);
            }
        }

        public IEnumerable<SubCategory> GetSubCategorys()
        {
            return _context.SubCategories;
        }

        public SubCategory GetSubCategory(int id)
        {
            var subcategory = _context.SubCategories.FirstOrDefault(c => c.Id == id);
            if (subcategory != null)
            {
                return subcategory;
            }
            return null;
        }

        public void Insert(SubCategory subcategory)
        {
            _context.SubCategories.Add(subcategory);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(SubCategory subcategory)
        {
            _context.SubCategories.Update(subcategory);
        }

        public IEnumerable<SubCategory> GetSubCategories()
        {
            throw new NotImplementedException();
        }
    }
}
