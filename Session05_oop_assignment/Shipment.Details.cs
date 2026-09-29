using System;
using System.Collections.Generic;
using System.Text;

namespace Session05_oop_assignment
{
    public partial class Shipment
    {

        private string trackingStatus;
        public string TrackingStatus => trackingStatus;

        public void updateTrackingstatus ( )
        {
            if (trackingStatus == "Ready")
            {
                trackingStatus = "not ready";
            }
            else {  trackingStatus = "Ready"; }
        }

        public string  Gettrackingstatus()
        {
            return trackingStatus; 
        }
    }
}
