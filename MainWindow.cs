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
	protected string rawStringToRGB ()
	{

		string rawRGBValue = colorselection2.CurrentColor.ToString();

		char[] delimiterChars = { ':', '/' };
		string[] rgbValues = rawRGBValue.Split(delimiterChars);

		//TODO: after converting from hex to int, convert the 0-65535 colourspace to the standard 0-255.
		//This horibleness is unfortunatley necessary to fix a bug with the red value not updating properlly. 
		Int32 redValue = Convert.ToInt32(rgbValues[1], 16);
		Int32 blueValue = Convert.ToInt32(rgbValues[2], 16);
		Int32 greenValue = Convert.ToInt32(rgbValues[3], 16);
		return $"rgb({redValue}, {blueValue}, {greenValue})";

	}

	protected void OnColorselection2ColorChanged (object sender, EventArgs e)
	{
		rawRGBResult.Text = colorselection2.CurrentColor.ToString();
		cssRGBOutput.Text = rawStringToRGB ();
	}
}
