
// This file has been generated by the GUI designer. Do not modify.
namespace HSVvis
{
	public partial class AboutWindow
	{
		private global::Gtk.Fixed fixed1;
		
		private global::Gtk.Image image1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HSVvis.AboutWindow
			this.Name = "HSVvis.AboutWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("AboutWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child HSVvis.AboutWindow.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.image1 = new global::Gtk.Image ();
			this.image1.Name = "image1";
			this.fixed1.Add (this.image1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.image1]));
			w1.X = 160;
			w1.Y = 82;
			this.Add (this.fixed1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
		}
	}
}