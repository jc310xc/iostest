using System;

using UIKit;

namespace iostest.iOS
{
	public partial class TabBarController : UITabBarController
	{
		public TabBarController(){
			ViewControllers = new UIViewController[] {
				new RedViewController(),
				new GreenViewController(),
				new BlueViewController()
			};


		}
	}
}


