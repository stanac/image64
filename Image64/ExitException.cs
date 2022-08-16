namespace Image64;

public class ExitException : Exception
{
    public int ExitCode { get; }
    
    public ExitException(string message, int exitCode)
        : base(message)
    {
        ExitCode = exitCode;
    }
}