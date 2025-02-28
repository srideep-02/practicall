using System;

class ConfigurationManager
{
    private static ConfigurationManager? instance;
    private static readonly object lockObject = new object();

    private ConfigurationManager() { }

    public static void Mainn(string[] args) {   GetInstance(); }

    public static ConfigurationManager GetInstance()
    {
        Console.WriteLine("Hello");
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();

                }
            }
        }
        return instance;
    }
}