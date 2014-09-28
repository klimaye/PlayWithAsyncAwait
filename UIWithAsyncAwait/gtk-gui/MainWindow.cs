
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TextView textview1;
	
	private global::Gtk.Button startButton;
	
	private global::Gtk.Button button2;
	
	private global::Gtk.Label logLabel;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		this.hbox1.BorderWidth = ((uint)(3));
		// Container child hbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView ();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.GtkScrolledWindow.Add (this.textview1);
		this.hbox1.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.GtkScrolledWindow]));
		w2.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.startButton = new global::Gtk.Button ();
		this.startButton.CanFocus = true;
		this.startButton.Name = "startButton";
		this.startButton.UseUnderline = true;
		this.startButton.Label = global::Mono.Unix.Catalog.GetString ("Start");
		this.hbox1.Add (this.startButton);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.startButton]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		w3.Padding = ((uint)(10));
		// Container child hbox1.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("Play with UI");
		this.hbox1.Add (this.button2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button2]));
		w4.PackType = ((global::Gtk.PackType)(1));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.logLabel = new global::Gtk.Label ();
		this.logLabel.Name = "logLabel";
		this.logLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("logLabel");
		this.vbox1.Add (this.logLabel);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.logLabel]));
		w6.Position = 1;
		w6.Expand = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.startButton.Clicked += new global::System.EventHandler (this.OnButton1Clicked);
		this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
	}
}
