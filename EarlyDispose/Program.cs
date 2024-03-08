class FileManager {
    public async void Write(string path, string message) {
        using (StreamWriter stream = new(path)) {
            await stream.WriteLineAsync(message);
        }
    }
    public string ReadLine(string path) {
        string result;
        using(StreamReader stream = new(path)) {
            result  = stream.ReadLine();
        }
        return result;
    }
}