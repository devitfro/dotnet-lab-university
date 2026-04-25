namespace Core.Services;

public class ResourceManager : IDisposable
{
    private StreamWriter _writer;

    public ResourceManager(string path)
    {
        _writer = new StreamWriter(path, true);
    }

    public void Log(string message)
    {
        _writer.WriteLine($"{DateTime.Now}: {message}");
    }

    public void Dispose()
    {
        if (_writer != null)
        {
            _writer.Close();
            _writer.Dispose();
        }
    }
}