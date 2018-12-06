using System;

namespace CSharpIntermediate
{
  public class ConsoleLogger : ILogger
  {
    public void LogError(string message)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      System.Console.WriteLine(message);
    }

    public void LogInfo(string message)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      System.Console.WriteLine(message);
    }
  }
}

