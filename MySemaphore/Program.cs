using System.Collections.Generic;

class SemaphoreTest
{
    static Thread[] t = new Thread[5];
    static Semaphore semaphore = new Semaphore(1, 1);
    static void DoSomething()
    {
        Console.WriteLine(Thread.CurrentThread.Name +"= waiting" );
        semaphore.WaitOne();
        Console.WriteLine( Thread.CurrentThread.Name+"= begins!");
        Thread.Sleep(1000);
        Console.WriteLine( Thread.CurrentThread.Name+ "= releasing...");
        semaphore.Release();
    }
    static void Main(string[] args)
    {
        for (int j = 0; j < 5; j++)
        {
            t[j] = new Thread(DoSomething);
            t[j].Name = "thread number " + j;
            t[j].Start();
        }
        Console.Read();
    }
}
