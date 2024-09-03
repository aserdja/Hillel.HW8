var threadArray = new Thread[5];
var semaphore = new Semaphore(2, 2);

for (int i = 0; i < threadArray.Length; i++)
{
	threadArray[i] = new Thread(() =>
	{
		semaphore.WaitOne();
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started");

		var r = new Random();
		Thread.Sleep(r.Next(1000, 5000));

		Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} finished");
		semaphore.Release();
	});
}

foreach (var thread in threadArray)
{
	thread.Start();
}

foreach (var thread in threadArray)
{
	thread.Join();
}