//using Assignmint_opp04;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Assignment_opp02
//{
//    internal class StandarShipment : Shipment, ITrackable, IInsurable
//    {
//        public StandarShipment(string TrackingCode, string Description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
//            : base(TrackingCode, Description, weight, deliveryFee, destination)
//        {
//        }

//        public override decimal EstimatedCost => DeliveryFee;

//        public override void APrintShipment()
//        {
//            Console.WriteLine("Standard Shipment\n");
//            Console.WriteLine($"Tracking Code : {TrackingCode}");
//            Console.WriteLine($"Description   : {Description}");
//            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
//        }

//        public string GetTrackingStatus()
//        {
//            return $"Shipment {TrackingCode} is Ready.";
//        }

//        public decimal CalculateInsurance()
//        {
//            return EstimatedCost * 0.05m;
//        }
//    }
//}

