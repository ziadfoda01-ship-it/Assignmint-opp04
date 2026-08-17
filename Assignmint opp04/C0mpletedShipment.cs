using Assignment_opp02;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmint_oop_03
{
    internal class CompletedShipment : Shipment
    {
        public DateTime compeletDate { get; set; }
        public CompletedShipment(string trackingcode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, DateTime completionData)
            : base(trackingcode, description, weight, deliveryFee, destination)
        {
            completionData = completionData;
        }
        public override decimal EstimatedCost => DeliveryFee;
        public override void APrintShipment()
        {
            Console.WriteLine("Completed Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Completed Date: {compeletDate}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}
