using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_opp02
{
    internal abstract class Shipment
    {
        public abstract decimal EstimatedCost { get;  }
        public abstract void APrintShipment();
        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryFee { get; set; }
        public DeliveryAddress Destination { get; set; }
       
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;


        }
        public void updatWeight(decimal newWeight)
        {
            Weight = newWeight;
        }
        public void updatWeight(decimal newWeight, decimal packingWeigh)
        {
            Weight = newWeight + packingWeigh;
        }
        public virtual void UpdateDeliveryFee()
        {

        }
        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");

        }
    }
}
