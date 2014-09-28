using System;
using Gtk;
using System.Threading.Tasks;
using System.Diagnostics;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		Log ("1. Task started");
		Task task = new Task(ProcessDataAsync);
		task.Start ();
		task.Wait ();
		Log ("3. Task scheduled");
	}

	async Task<int> SomethingThatTakesTime ()
	{
		//await Task.Delay(5000);
		int counter = 20;
		while(counter >= 0)
		{
			//Console.WriteLine("doing something else {0}",counter--);
			Log("4. doing something else {0}",counter--);
			await Task.Delay(500);
		}
		return 20;
	}

	async void ProcessDataAsync()
	{
		Task<int> promise = SomethingThatTakesTime ();
		Log("2. Please wait patiently " + "while I do something important.");
		int result = await promise;
		Log("5. result of long running task was {0}",result);
	}

	private void Log(string format, params object[] values)
	{
		string text = string.Format(format, values);
		string line = string.Format("{0:HH:mm:ss.fff}: {1}\r\n", DateTime.Now, text);
		logLabel.Text += line;
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		int numThreads = Process.GetCurrentProcess().Threads.Count;
		Log ("Responsive ui. thread count {0}",numThreads);
	}
}
