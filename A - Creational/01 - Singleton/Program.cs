using Singleton;
using static Singleton.Implementation;

Console.Title = "Singleton";

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if(instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Instances are same");
}

instance1.Log($"Message from - {nameof(instance1)}");
instance2.Log($"Message from - {nameof(instance2)}");
Logger.Instance.Log($"Message from - {nameof(Logger.Instance)}");

Console.ReadLine();