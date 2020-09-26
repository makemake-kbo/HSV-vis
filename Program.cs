using System;
using Gtk;

namespace HSVvis
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			AboutWindow about = new AboutWindow ();
			win.Show ();
			about.Show ();

			Application.Run ();
		}
	}
}
