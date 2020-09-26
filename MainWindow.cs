using System;
using Gtk;
using HSVvis;

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
	//ie. converts rgb:ffff/ffff/ffff to rgb(255, 255, 255)
	protected string rawStringToRGB (bool is8bit)
	{

		string rawRGBValue = colorselection2.CurrentColor.ToString();

		char[] delimiterChars = { ':', '/' };
		string[] rgbValues = rawRGBValue.Split(delimiterChars);

		//TODO: We do coverted the 16-bit colourspace, but the conversion is wrong. Too bad!

		//This horibleness is unfortunatley necessary to fix a bug with the red value not updating properlly. 
		Int32 redValue = Convert.ToInt32 (rgbValues[1], 16);
		Double red8bitValue = Math.Truncate (Math.Sqrt (redValue));

		Int32 blueValue = Convert.ToInt32 (rgbValues[2], 16);
		Double blue8bitValue = Math.Truncate (Math.Sqrt (blueValue));

		Int32 greenValue = Convert.ToInt32 (rgbValues[3], 16);
		Double green8bitValue = Math.Truncate (Math.Sqrt (greenValue));

		if (is8bit) {
			return $"rgb({red8bitValue}, {blue8bitValue}, {green8bitValue})";
		} else {
			return $"rgb({redValue}, {blueValue}, {greenValue})";
		}
	}

	protected void OnColorselection2ColorChanged (object sender, EventArgs e)
	{
		rawRGBResult.Text = colorselection2.CurrentColor.ToString();
		cssRGB8bitOutput.Text = rawStringToRGB ( true );
		cssRGB16bitOutput.Text = rawStringToRGB ( false );
	}

	public void OnAboutActionActivated (object sender, EventArgs e)
	{
		//AboutWindow.Build ();
	}
		
	protected void OnQuitActionActivated (object sender, EventArgs e)
	{
		Application.Quit ();
		a.RetVal = true;
	}

}
