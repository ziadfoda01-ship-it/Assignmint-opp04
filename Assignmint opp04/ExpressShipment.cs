using Assignmint_opp04;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_opp02
{
    internal class ExpressShipment : Shipment ,IInsurable,ITrackable
    {
        public decimal ExtraFee { get; set; }

        public override decimal EstimatedCost => DeliveryFee + ExtraFee;

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override void APrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");


        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }
    }
}
