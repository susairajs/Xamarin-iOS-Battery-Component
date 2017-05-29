using System;
using UIKit;

using Battery.Plugin;

namespace XamariniOSBatteryComponent
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void BtnGet_TouchUpInside(UIButton sender)
		{
			lblLevel.Text = "Level:" + CrossBattery.Current.RemainingChargePercent;
			lblStatus.Text = "Status:" + CrossBattery.Current.Status.ToString();
			lblIsLow.Text = "IsLow:" + ((CrossBattery.Current.RemainingChargePercent >= 15) ? "YES" : "NO");
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
