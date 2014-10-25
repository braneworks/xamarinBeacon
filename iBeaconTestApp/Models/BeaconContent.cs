using System;
using MonoTouch.CoreLocation;
using MonoTouch.Foundation;

namespace iBeaconTestApp.Models
{

	public class BeaconContent : NSObject
	{
		public BeaconContent ()
		{
		}

		public void Clear()
		{
			this.NotificationTitle = string.Empty;
			this.ViewImage = string.Empty;
			this.ViewContent = string.Empty;
			this.ContentId = string.Empty;
			this.DisplayDelay = new TimeSpan (0, 0, 0);
			this.Region = string.Empty;
			this.Major = string.Empty;
			this.Minor = string.Empty;	
			this.Rssi = 0;
			this.ProximityUuid = string.Empty;
			this.Accuracy = 0.0;
			this.Proximity = CLProximity.Unknown;
			this.RegionEventName = string.Empty;
			this.RegionEvent = CLRegionState.Unknown;
		}

		public string NotificationTitle {
			get;
			set;
		}

		public string ViewImage {
			get;
			set;
		}

		public string ViewContent {
			get;
			set;
		}

		public string NotificationMessage {
			get;
			set;
		}
			
			
		public string ContentId {
			get;
			set;
		}
		public TimeSpan DisplayDelay {
			get;
			set;
		}

		public string Region{
			get;
			set;
		}

		public string Major{
			get;
			set;
		}

		public string Minor{
			get;
			set;
		}

		public string ProximityUuid{
			get;
			set;
		}

		public CLProximity Proximity{
			get;
			set;
		}

		public double Accuracy{
			get;
			set;
		}

		public int Rssi{
			get;
			set;
		}

		public CLRegionState RegionEvent {
			get;
			set;
		} 

		public string RegionEventName {
			get;
			set;
		} 
	}
}

