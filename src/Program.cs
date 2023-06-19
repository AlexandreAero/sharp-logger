using System;

class Program
{
    static void Main()
    {
        SharpLogger logger = new SharpLogger("./out.md", true);

        logger.Log("Let's take a look at it! 👀", LogLevel.INFO);
        logger.Log("Let's ignore that 😴", LogLevel.WARNING);
        logger.Log("🚨 Red alert", LogLevel.ERROR);
        logger.Log("Oh no 😩", LogLevel.FATAL);
        logger.Log("I can do more, {0} + {1} = {2}", LogLevel.INFO, "🌱", "💦", "🌽");
        
        logger.Close();

        Console.WriteLine("Logging complete. Press any key to exit.");
        Console.ReadKey();
    }
}
