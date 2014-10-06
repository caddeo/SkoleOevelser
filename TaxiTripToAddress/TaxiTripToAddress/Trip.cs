using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiTripToAddress
{
    class Trip
    {
        public TimeSpan startTimeDate { get; set; }
        public TimeSpan endTimeDate { get; set; }

        public double pricePrMinute { get; set; }
        public double startingFee {get; set;}
        public Address address { get; set; }

        public Trip(double pricePrMinute, double startingFee, Address address)
        {
            this.pricePrMinute = pricePrMinute;
            this.startingFee = startingFee;
            this.address = address;
        }

        public Trip(double startingFee, Address address)
        {
            this.startingFee = startingFee;
            this.address = address;
        }

        public Trip(Address address)
        {
            this.address = address;
        }

        public void startTime()
        {
            this.startTimeDate = DateTime.Now.TimeOfDay;
        }

        public void endTime()
        {
            this.endTimeDate = DateTime.Now.TimeOfDay;
        }

        public double tripInMinutes()
        {
            return endTimeDate.TotalMinutes - startTimeDate.TotalMinutes;
        }

        public double tripInHours()
        {
            return endTimeDate.TotalHours - startTimeDate.TotalHours;
        }

        public double calculatePrice()
        {
            return tripInMinutes() * pricePrMinute;
        }

        public string getTotalTravelTime()
        {
            return 
                (endTimeDate.Hours      - startTimeDate.Hours   ).ToString()    + " : "+
                (endTimeDate.Minutes    - startTimeDate.Minutes ).ToString()    + " : "+
                (endTimeDate.Seconds    - startTimeDate.Seconds ).ToString()
                ;
        }
    }
}
