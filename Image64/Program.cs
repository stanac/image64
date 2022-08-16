using TextCopy;

namespace Image64;

public static class Program
{
    private static readonly IReadOnlyList<string> _supportedExtensions = new List<string>
    {
        "jpeg",
        "jpg",
        "bmp",
        "png",
        "gif"
    };

    public static int Main(string[] args)
    {
        try
        {
            ValidateArgs(args);
        }
        catch (ExitException e)
        {
            WriteError(e.Message);
            return e.ExitCode;
        }
        
        string data = Convert(args[0]);

        new Clipboard().SetText(data);

        Console.WriteLine("---------------");
        Console.WriteLine(data);
        Console.WriteLine("---------------");
        WriteSuccess("Base64 image text copied to clipboard.");

        return 0;
    }

    private static string Convert(string filePath)
    {
        byte[] bytes = File.ReadAllBytes(filePath);
        string base64 = System.Convert.ToBase64String(bytes);

        string extension = new FileInfo(filePath).Extension.TrimStart('.').ToLower();
        
        if (extension == "jpg") extension = "jpeg";

        return $"data:image/{extension};base64, {base64}";
    }

    private static void ValidateArgs(string[] args)
    {
        if (args.Length != 1)
        {
            throw new ExitException("Expected one and only one input argument.", 10);
        }

        string filePath = args[0];

        if (!File.Exists(filePath))
        {
            throw new ExitException($"File at path `{filePath}` does not exist.", 20);
        }

        FileInfo fi = new FileInfo(filePath);
        string extension = fi.Extension.TrimStart('.').ToLower();

        if (extension == "jpg") extension = "jpeg";

        if (!_supportedExtensions.Contains(extension))
        {
            string msg = $"Extension `{extension}` is not supported. Supported extensions are: `"
                         + string.Join("`, `", _supportedExtensions) + "`.";
            throw new ExitException(msg, 30);
        }
    }

    private static void WriteError(string text) => WriteColored(text, ConsoleColor.Red, ConsoleColor.White);

    private static void WriteSuccess(string text) => WriteColored(text, ConsoleColor.DarkGreen, ConsoleColor.White);

    private static void WriteColored(string text, ConsoleColor bc, ConsoleColor fc)
    {
        ConsoleColor oldBc = Console.BackgroundColor;
        ConsoleColor oldFc = Console.ForegroundColor;

        Console.ForegroundColor = fc;
        Console.BackgroundColor = bc;

        Console.WriteLine(text);

        Console.ForegroundColor = oldFc;
        Console.BackgroundColor = oldBc;
    }

}