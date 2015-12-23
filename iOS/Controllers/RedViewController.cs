using System;

using UIKit;

namespace iostest.iOS
{
	public partial class RedViewController : UIViewController
	{
		public RedViewController () : base ("RedViewController", null)
		{
			Title = "Red";
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			View.BackgroundColor = UIColor.Red;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


