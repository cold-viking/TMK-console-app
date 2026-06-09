using SpaceObjects.Entities;
using SpaceObjects.Services;


namespace SpaceObjects.Repository;

public class CosmoObjectRepository
{
    private readonly string _fileName;
    private readonly List<CosmoObject> _cosmoObjects;

    public CosmoObjectRepository(string fileName)
    {
        _fileName = fileName;
        _cosmoObjects = Reader.Load<List<CosmoObject>>(fileName);
    }
    
    private CosmoObject? GetById(Guid id)
    {
        return _cosmoObjects
            .FirstOrDefault(cosmoObject => cosmoObject.Id == id);
    }
    
    private void Save()
    {
        Writer.Save(_cosmoObjects, _fileName);
    }
    
    public List<CosmoObject> GetAll()
    {
        return _cosmoObjects;
    }

    public List<CosmoObject> GetByType(string type)
    {
        return _cosmoObjects
            .Where(cosmoObject => cosmoObject.Type == type)
            .ToList();
    }

    public void Add(CosmoObject cosmoObject)
    {
        _cosmoObjects.Add(cosmoObject);
        Save();
    }
    
    public bool Delete(Guid id)
    {
        var cosmoObject = GetById(id);

        if (cosmoObject is null)
        {
            return false;
        }

        _cosmoObjects.Remove(cosmoObject);
        Save();

        return true;
    }

    public bool Update(Guid id, CosmoObject newCosmoObject)
    {
        var oldCosmoObject = GetById(id);

        if (oldCosmoObject is null)
        {
            return false;
        }

        var index = _cosmoObjects.IndexOf(oldCosmoObject);

        newCosmoObject.Id = id;
        _cosmoObjects[index] = newCosmoObject;

        Save();

        return true;
    }

    public void RewriteAll(List<CosmoObject> cosmoObjects)
    {
        _cosmoObjects.Clear();
        _cosmoObjects.AddRange(cosmoObjects);

        Save();
    }

}