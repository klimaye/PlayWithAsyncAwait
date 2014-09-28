using System;
using System.Threading.Tasks;

namespace PlayWithAsyncAwait
{
	class MainClass
	{
		static async Task<int> SomethingThatTakesTime ()
		{
			await Task.Delay(5000);
			int counter = 20;
			while(counter >= 0)
			{
				Console.WriteLine("doing something else {0}",counter--);
				await Task.Delay(10);
			}
			return 20;
		}

		static async void ProcessDataAsync()
		{
			Task<int> promise = SomethingThatTakesTime ();
			Console.WriteLine("Please wait patiently " +
				"while I do something important.");
			int result = await promise;
			Console.WriteLine("result of long running task was {0}",result);
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Task task = new Task(ProcessDataAsync);
			task.Start ();
			task.Wait ();
			Console.ReadLine();				
		}
	}
}
