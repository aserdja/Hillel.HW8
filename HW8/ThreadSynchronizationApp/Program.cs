int counter = 0;
object lockObject = counter;

var thread1 = new Thread(() => 
{
	lock (lockObject)
	{
		for (int i = 0; i < 1000; i++)
		{
			counter++;
			//Console.WriteLine($"Thread 1");
		}
        Console.WriteLine("Successfully 1");
    }
});

var thread2 = new Thread(() =>
{
	lock (lockObject)
	{
		for (int i = 0; i < 1000; i++)
		{
			counter++;
            //Console.WriteLine($"Thread 2");
        }
		Console.WriteLine("Successfully 2");
	}
});

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

Console.WriteLine(counter);
