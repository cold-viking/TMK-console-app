using SpaceObjects.Data;
using SpaceObjects.Entities;

namespace SpaceObjects.Services;

public class CosmoDbService
{
    private readonly AppDbContext _db;

    public CosmoDbService(AppDbContext db)
    {
        _db = db;
    }

    public void Add(CosmoObject obj)
    {
        _db.CosmoObjects.Add(obj);
        _db.SaveChanges();
    }

    public List<CosmoObject> GetAll()
    {
        return _db.CosmoObjects.ToList();
    }
}