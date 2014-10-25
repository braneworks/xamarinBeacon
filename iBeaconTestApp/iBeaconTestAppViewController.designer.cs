// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace iBeaconTestApp
{
	[Register ("iBeaconTestAppViewController")]
	partial class iBeaconTestAppViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView imgAd { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblAccuracy { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblAdtext { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblMajor { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblMessageTitle { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblMinor { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblProximity { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblRegioName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblrssi { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblUUID { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imgAd != null) {
				imgAd.Dispose ();
				imgAd = null;
			}

			if (lblAccuracy != null) {
				lblAccuracy.Dispose ();
				lblAccuracy = null;
			}

			if (lblAdtext != null) {
				lblAdtext.Dispose ();
				lblAdtext = null;
			}

			if (lblMajor != null) {
				lblMajor.Dispose ();
				lblMajor = null;
			}

			if (lblMessageTitle != null) {
				lblMessageTitle.Dispose ();
				lblMessageTitle = null;
			}

			if (lblMinor != null) {
				lblMinor.Dispose ();
				lblMinor = null;
			}

			if (lblProximity != null) {
				lblProximity.Dispose ();
				lblProximity = null;
			}

			if (lblRegioName != null) {
				lblRegioName.Dispose ();
				lblRegioName = null;
			}

			if (lblrssi != null) {
				lblrssi.Dispose ();
				lblrssi = null;
			}

			if (lblUUID != null) {
				lblUUID.Dispose ();
				lblUUID = null;
			}
		}
	}
}
