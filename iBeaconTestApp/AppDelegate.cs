﻿using MonoTouch.Foundation;
using MonoTouch.UIKit;
using iBeaconTestApp.Models;
using MonoTouch.CoreLocation;
using System;
namespace iBeaconTestApp
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{

		// class-level declarations
		public override UIWindow Window {
			get;
			set;
		}

		private CLLocationManager _locationManager;
		public CLLocationManager ShareLocationManager
		{
			get
			{
				if(_locationManager == null)
				{
					_locationManager = new CLLocationManager ();
					_locationManager.Delegate = new CoreLocation ();
					if (UIDevice.CurrentDevice.CheckSystemVersion (8, 0)) {
						_locationManager.RequestAlwaysAuthorization ();
					}

				}
				return _locationManager;
			}
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			Console.WriteLine ("Launched");
			ShareLocationManager.StartMonitoring(Region.RegionToMonitor);
			return true;
		}

		#region lifecycle
		// This method is invoked when the application is about to move from active to inactive state.
		// OpenGL applications should use this method to pause.
		public override void OnResignActivation (UIApplication application)
		{
		}
		// This method should be used to release shared resources and it should store the application state.
		// If your application supports background exection this method is called instead of WillTerminate
		// when the user quits.
		public override void DidEnterBackground (UIApplication application)
		{
			//let the subscribing views know we are changing state
		}
		// This method is called as part of the transiton from background to active state.
		public override void WillEnterForeground (UIApplication application)
		{
		}

		// This method is called when the application is about to terminate. Save data, if needed.
		public override void WillTerminate (UIApplication application)
		{
		}

		#endregion
		public override void OnActivated (UIApplication application)
		{
			Console.WriteLine ("Activated");
			//ShareLocationManager.StartMonitoring (Region.RegionToMonitor);
		}
	

		public override void ReceivedLocalNotification(UIApplication application, UILocalNotification notification)
		{
			// show an alert
			new UIAlertView(notification.AlertAction, notification.AlertBody, null, "OK", null).Show();

			// reset our badge
			UIApplication.SharedApplication.ApplicationIconBadgeNumber = 0;
		}
	}
}

