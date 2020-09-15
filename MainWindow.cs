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

	//This function takes the raw value colorselection responds with and
	//makes it so it can be used with CSS's rgb() function
	//ie. converts rgb:dc54/5538/5538 to rgb(dc54, 5538, 5538)
	protected void rawStringToRGB ()
	{
		string rawRGBValue = colorselection2.CurrentColor.ToString();

		char[] delimiterChars = { ':', '/' };
		string[] rgbValues = rawRGBValue.Split(delimiterChars);
		string parsedRGBValues = $"rgb({rgbValues[1]}, {rgbValues[2]}, {rgbValues[3]})";

		cssRGBOutput.Text = parsedRGBValues;
	}

	protected void OnColorselection2ColorChanged (object sender, EventArgs e)
	{
		rawRGBResult.Text = colorselection2.CurrentColor.ToString();
		rawStringToRGB ();
	}
}
