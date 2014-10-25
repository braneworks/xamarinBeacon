using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using iBeaconTestApp.Models;

namespace iBeaconTestApp
{
	public partial class iBeaconTestAppViewController : UIViewController
	{
		NSObject _contentUpdate;

		public iBeaconTestAppViewController (IntPtr handle) : base (handle)
		{
		}

		#region View lifecycle


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Console.WriteLine ("Load");
		}
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			Console.WriteLine ("WillAppear");

			_contentUpdate =  NSNotificationCenter.DefaultCenter.AddObserver ((NSString)"ContentUpdate", OnContentUpdate);
		}

		public override void ViewWillDisappear (bool animated)
		{
			_contentUpdate.Dispose();
			base.ViewWillDisappear (animated);
		}


		public void OnContentUpdate(NSNotification notification)
		{
			var content = notification.UserInfo.ValueForKey ((NSString)"Content") as BeaconContent;
			DisplayContent (content);
		}

		void DisplayContent (BeaconContent content)
		{
			imgAd.Image = UIImage.FromBundle(content.ViewImage);
			lblAdtext.Text = content.ViewContent;
			lblProximity.Text = content.Proximity.ToString ();
		}

		#endregion
	}
}


