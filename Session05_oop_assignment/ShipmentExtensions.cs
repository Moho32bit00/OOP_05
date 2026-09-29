using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Session05_oop_assignment
{
    public  static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} , {shipment.GetType().Name} ,{shipment.Weight}, {shipment.TrackingStatus} . ";
        }
        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment.TrackingStatus == "Delivered") {
                return true;
            }
            else { return false; }
        }
    }
}
