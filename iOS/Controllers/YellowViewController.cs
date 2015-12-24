using System;

using UIKit;

namespace iostest.iOS
{
	public partial class YellowViewController : UIViewController
	{
		public YellowViewController () : base ("YellowViewController", null)
		{
			Title = "Yellow";
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			View.BackgroundColor = UIColor.Yellow;
		}
	}
}


