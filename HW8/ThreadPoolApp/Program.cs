using ThreadPoolApp;

var workItems = new string[10]
{
	"Task 1",
	"Task 2",
	"Task 3",
	"Task 4",
	"Task 5",
	"Task 6",
	"Task 7",
	"Task 8",
	"Task 9",
	"Task 10"
};

foreach (var item in workItems)
{
	ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadPoolInformator.ShowInfo), item);
}

Thread.Sleep(2000);


