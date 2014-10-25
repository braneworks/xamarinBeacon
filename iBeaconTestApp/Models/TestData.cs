using System;
using MonoTouch.CoreLocation;

namespace iBeaconTestApp.Models
{
	public class TestData
	{
		BeaconContent[] regions;
		BeaconContent[] beacons ;

		void LoadTestData ()
		{

			//Dummy data that would be part of a CMS system
			regions = new BeaconContent[2] 
			{
				new BeaconContent() {
					ContentId = "1", 
					DisplayDelay = new TimeSpan(0,0,0),
					Region = Globals.BeaconRegion,
					NotificationTitle = "Test App!",
					NotificationMessage ="Welome to Fashion Place!", 
					ViewImage = "Images/ibeaconEnter", 
					ViewContent = "Welcome to Fashion Place!", 
					RegionEventName = "RegionEntered",
					RegionEvent = MonoTouch.CoreLocation.CLRegionState.Inside},

				new BeaconContent() {
					ContentId = "2", 
					DisplayDelay = new TimeSpan(0,0,0), 
					Region = Globals.BeaconRegion,
					NotificationTitle = "Test App!",
					NotificationMessage = "Come back soon!!", 
					ViewImage = "Images/ibeaconExit", 
					ViewContent = "Fashion Place will miss you!",
					RegionEventName = "RegionLeft",
					RegionEvent =  MonoTouch.CoreLocation.CLRegionState.Outside}

			};


			beacons = new BeaconContent[3] 
			{
				new BeaconContent() {
					ContentId = "3", 
					DisplayDelay = new TimeSpan(0,0,0), 
					Region = Globals.BeaconRegion,
					Proximity = CLProximity.Far, 
					NotificationTitle = "",
					NotificationMessage = "", 
					ViewImage = "Images/ibeaconFar", 
					ViewContent = "Hurry the deals won't last long!",
					Major = "24905", 
					Minor = "23994", 
					RegionEventName = "Ranging",
					ProximityUuid  = "B9407F30-F5F8-466E-AFF9-25556B57FE6D"},

				new BeaconContent() {
					ContentId = "4", 
					DisplayDelay = new TimeSpan(0,0,0), 
					Region = Globals.BeaconRegion,
					Proximity = CLProximity.Immediate,  
					NotificationTitle = "",
					NotificationMessage = "", 
					ViewImage = "Images/ibeaconAtBeacon", 
					ViewContent = "OMG!  Great Deal on Jacket!",
					Major = "24905", 
					Minor = "23994", 
					RegionEventName = "Ranging",
					ProximityUuid  = "B9407F30-F5F8-466E-AFF9-25556B57FE6D"},

				new BeaconContent() {
					ContentId = "5",
					DisplayDelay = new TimeSpan(0,0,0),
					Region = Globals.BeaconRegion,
					Proximity = CLProximity.Near, 
					NotificationTitle = "",
					NotificationMessage = "", 
					ViewImage = "Images/ibeaconEnter", 
					ViewContent = "You are closer to a great deal!",
					Major = "24905", 
					Minor = "23994", 
					RegionEventName = "Ranging",
					ProximityUuid  = "B9407F30-F5F8-466E-AFF9-25556B57FE6D"},

			};
		}

		public TestData ()
		{
			LoadTestData ();
		}

		public BeaconContent[] GetRegionContent()
		{
			return regions;
		}

		public BeaconContent[] GetBeaconContent()
		{
			return beacons;
		}



	}
}

