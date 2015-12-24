using System;

using UIKit;

namespace iostest.iOS
{
	public partial class PurpleViewController : UIViewController
	{
		public PurpleViewController () : base ("PurpleViewController", null)
		{
			Title = "Purple";
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			View.BackgroundColor = UIColor.Purple;


		}
	}
}


