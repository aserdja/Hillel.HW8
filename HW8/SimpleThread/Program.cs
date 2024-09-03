var thread1 = new Thread(() =>
{
	for (int i = 0; i < 10; i++)
	{
        Console.WriteLine($"Thread: {"Thread 1"}; Id: {Thread.CurrentThread.ManagedThreadId}");
		Thread.Sleep(500);
    }
});

var thread2 = new Thread(() =>
{
	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine($"Thread: {"Thread 2"}; Id: {Thread.CurrentThread.ManagedThreadId}");
		Thread.Sleep(500);
	}
});

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();
