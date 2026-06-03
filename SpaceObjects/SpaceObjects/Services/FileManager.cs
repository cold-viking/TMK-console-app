namespace SpaceProj.Services;

public static class FileManager
{
    public static void CreateIfNotExists<T>(string fileName, T data)
    {
        if (File.Exists(fileName))
        {
            return;
        }

        Writer.Save(data, fileName);
    }
}