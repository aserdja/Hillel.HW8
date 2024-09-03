namespace ThreadPoolApp
{
	public static class ThreadPoolInformator
	{
		public static void ShowInfo(object? data)
		{
			Console.WriteLine($"{data} completed in Thread №{Thread.CurrentThread.ManagedThreadId}");
		}
	}
}
