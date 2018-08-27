using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*******************************************************
 * Author: Brian Liang 
 * Date: July-2018
 * Purpose: Prop for Booking
 *******************************************************/

namespace TravelExpertsWeb.App_Code
{
    public class Booking
    {
        //from the booking table
        // Getter/Accessors for the booking table
        public int BookingId { get; set; }

        public DateTime? BookingDate { get; set; }

        public string BookingNo { get; set; }

        public double? TravelerCount { get; set; }

        public int? CustomerId { get; set; }

        public string TripTypeId { get; set; }

        public int? PackageId { get; set; }

        //from the booking detail table
        // Getter/Accessors for the booking detail table

        public int BookingDetailId { get; set; }

        public double? ItineraryNo { get; set; }

        public DateTime? TripStart { get; set; }

        public DateTime? TripEnd { get; set; }

        public string Description { get; set; }

        public string Destination { get; set; }

        public decimal BasePrice { get; set; }

        public decimal? AgencyCommission { get; set; }

        public string RegionId { get; set; }

        public string ClassId { get; set; }

        public string FeeId { get; set; }

        public int ProductSupplierId { get; set; }

    }
}