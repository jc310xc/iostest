using System;

using UIKit;

namespace iostest.iOS
{
	public partial class GreenViewController : UIViewController
	{
		public GreenViewController () : base ("GreenViewController", null)
		{
			Title = "Green";
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			View.BackgroundColor = UIColor.Green;


		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void HandleYellowTouch(UIButton sender){
			NavigationController.PushViewController(new YellowViewController(),false);
		}

		partial void HandlePurpleTouch (UIButton sender)
		{
			NavigationController.PushViewController(new PurpleViewController(),false);
		}
	}
}


