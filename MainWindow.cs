using System;
using Gtk;

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

	protected void OnColorselection2ColorChanged (object sender, EventArgs e)
	{
		rawRGBResult.Text= colorselection2.CurrentColor.ToString();
	}
}
