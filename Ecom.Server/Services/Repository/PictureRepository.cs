using Ecom.Server.Data;
using Ecom.Server.Models;
using Ecom.Server.Services.Infrastructure;

namespace Ecom.Server.Services.Repository
{ 
 public class PictureRepository(ApplicationDbContext context) : IPicture
{
    private ApplicationDbContext _context = context;

    public int Count()
    {
        return _context.Pictures.Count();
    }

    public void Delete(int id)
    {
        var picture = _context.Pictures.FirstOrDefault(c => c.Id == id);
        if (picture != null)
        {
            _context.Pictures.Remove(picture);
        }
    }

    public IEnumerable<Picture> GetPictures()
    {
        return _context.Pictures;
    }

    public Picture GetPicture(int id)
    {
        var picture = _context.Pictures.FirstOrDefault(c => c.Id == id);
        if (picture != null)
        {
            return picture;
        }
        return null;
    }

    public void Insert(Picture picture)
    {
        _context.Pictures.Add(picture);
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void Update(Picture Picture)
    {
        _context.Pictures.Update(Picture);
    }
}
}
