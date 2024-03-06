class FileManager {
    public void Write(string path, string message) {
        StreamWriter stream = new(path);
        stream.WriteLine(message);
        stream.Dispose();
    }
    public string ReadLine(string path) {
        StreamReader stream = new(path);
        string result = stream.ReadLine();
        stream.Dispose();
        return result;
    }
}