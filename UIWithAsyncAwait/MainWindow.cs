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
	/// <summary>
	/// event handler marked as async. 
	/// </summary>
	/// <param name="sender">Sender.</param>
	/// <param name="e">E.</param>
	protected async void OnButton1Clicked (object sender, EventArgs e)
	{
		Task<int> promise = SomethingThatTakesTime ();
		Log ("1. Promise created");
		Log("2. Please wait patiently " + "while I do something important.");
		int result = await promise;
		Log("5. result of long running task was {0}",result);
	}

	async Task<int> SomethingThatTakesTime ()
	{
		//await Task.Delay(5000);
		int counter = 20;
		while(counter >= 0)
		{
			//Console.WriteLine("doing something else {0}",counter--);
			Log("4. doing something else {0}",counter--);
			//Note : await can only be called in a method that is marked as async
			await Task.Delay(500);
		}
		return 20;
	}
	/// <summary>
	/// given that async doesn't create threads, I am able to manipulate the ui directly without having to
	// invoke the ui thread.
	/// </summary>
	/// <param name="format">Format.</param>
	/// <param name="values">Values.</param>
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
