using System;
using System.Collections.Generic;
using System.Text;

namespace Session05_oop_assignment
{
    public partial class Shipment
    {

        private string trackingStatus;
        public string TrackingStatus => trackingStatus;

        public void updateTrackingstatus(string newStatus)
        {
            OnTrackingStatusChanged(newStatus);
        }

        public partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }

        public string  Gettrackingstatus()
        {
            return trackingStatus; 
        }
    }
}
