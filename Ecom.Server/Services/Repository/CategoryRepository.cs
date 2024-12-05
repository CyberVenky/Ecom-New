using Ecom.Server.Data;
using Ecom.Server.Models;
using Ecom.Server.Services.Infrastructure;

namespace Ecom.Server.Services.Repository
{
    public class CategoryRepository(ApplicationDbContext context) : ICategory
    {
        public ApplicationDbContext _Context = context;

        public IEnumerable<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(int id)
        {
            var category = _Context.Categories.FirstOrDefault(c => c.Id == id);
            if (category!= null)
            {
                return category;
            }

            return null;
        }

        public void Insert(Category category)
        {
             _Context.Categories.Add(category);
        }

        public void Update(Category category)
        {

            _Context.Categories.Update(category);
        }

        public void Delete(int id)
        {
          var category = _Context.Categories.FirstOrDefault(c=>c.Id==id);
          if (category != null)
          {
              _Context.Categories.Remove(category);
          }
        }

        public int Count()
        {
            return _Context.Categories.Count();
        }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
