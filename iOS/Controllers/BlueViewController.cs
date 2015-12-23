using System;

using UIKit;

namespace iostest.iOS
{
	public partial class BlueViewController : UIViewController
	{
		public BlueViewController () : base ("BlueViewController", null)
		{
			Title = "Blue";
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			View.BackgroundColor = UIColor.Blue;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


