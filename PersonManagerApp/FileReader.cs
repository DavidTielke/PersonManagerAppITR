namespace PersonManagerApp;

public class FileReader
{
    public IEnumerable<string> ReadAllLines(string path)
    {
        var lines = File.ReadAllLines(path);
        return lines;
    }
}