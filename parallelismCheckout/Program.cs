// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var thread1 = new Thread(() =>
{
    int c = 0;
    while (c < 10)
    {
        try
        {
            c++;
            Console.WriteLine("t1 - " + $"{c}");
            if (c == 5)
                Thread.Sleep(Timeout.Infinite);
            else
                Thread.Sleep(100);
            
        }
        catch (ThreadInterruptedException ex)
        {
            Console.WriteLine("t1 interrupted");
            Thread.Sleep(250);
        }
    }
});

var thread2 = new Thread(() =>
{
    int c = 0;
    while (c < 15)
    {
        Console.WriteLine("t2 - " + $"{c}");
        Thread.Sleep(150);
        c++;
    }
    thread1.Interrupt();
});
thread2.IsBackground = true;

thread1.Start();
thread2.Start();
Console.ReadKey();