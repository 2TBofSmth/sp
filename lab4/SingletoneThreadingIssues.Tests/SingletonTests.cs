using System;
using System.Threading;
using Xunit;

public class SingletonTests
{
    [Fact]
    public void ThreadSafeSingleton_CreatesSingleInstance()
    {
        Thread[] threads = new Thread[10];
        var instanceHashCodes = new HashSet<int>();
        
        for (int i = 0; i < 10; i++)
        {
            threads[i] = new Thread(() =>
            {
                var instance = Singleton.Instance;
                instanceHashCodes.Add(instance.GetHashCode());
            });
        }
        
        foreach (var thread in threads)
        {
            thread.Start();
        }
        foreach (var thread in threads)
        {
            thread.Join();
        }
        
        Assert.Single(instanceHashCodes);
    }

    [Fact]
    public void ThreadUnsafeSingleton_CreatesMultipleInstances()
    {
        Thread[] threads = new Thread[10];
        var instanceHashCodes = new HashSet<int>();
        
        for (int i = 0; i < 10; i++)
        {
            threads[i] = new Thread(() =>
            {
                var instance = Singleton.Instance;
                instanceHashCodes.Add(instance.GetHashCode());
            });
        }
        
        foreach (var thread in threads)
        {
            thread.Start();
        }
        foreach (var thread in threads)
        {
            thread.Join();
        }
        
        Assert.True(instanceHashCodes.Count > 1, "Multiple instances were created.");
    }
}