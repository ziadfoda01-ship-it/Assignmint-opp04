using Assignmint_opp04;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_opp02
{
    internal class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        public string DestinationCountry { get; set; }
        public decimal CustomsFee { get; set; }

        public override decimal EstimatedCost => DeliveryFee + CustomsFee;

        public InternationalShipment(string tragkingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(tragkingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override void APrintShipment()
        {
            Console.WriteLine("International Shipment\n");
            Console.WriteLine($"Tracking Code      : {TrackingCode}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee        : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost     : {EstimatedCost} EGP");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Generating customs report for {DestinationCountry}");
        }

        
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} to {DestinationCountry} is in Transit.";
        }

        
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}

