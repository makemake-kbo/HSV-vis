
// This file has been generated by the GUI designer. Do not modify.
namespace HSVvis
{
	public partial class AboutWindow
	{
		private global::Gtk.Fixed fixed1;
		
		private global::Gtk.Image image1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HSVvis.AboutWindow
			this.Name = "HSVvis.AboutWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("AboutWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child HSVvis.AboutWindow.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.image1 = new global::Gtk.Image ();
			this.image1.Name = "image1";
			this.fixed1.Add (this.image1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.image1]));
			w1.X = 174;
			w1.Y = 83;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("HSV-vis is licensed under the BSD-2-clause license");
			this.fixed1.Add (this.label2);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label2]));
			w2.X = 35;
			w2.Y = 183;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("HSV-vis Alpha Development Build");
			this.fixed1.Add (this.label1);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
			w3.X = 89;
			w3.Y = 147;
			this.Add (this.fixed1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 403;
			this.DefaultHeight = 300;
			this.Show ();
		}
	}
}
