using System.ComponentModel.DataAnnotations;

namespace OnlineRailwayReservationSystem.Models
{
    public class FareRule
    {
        [Key]
        public int Fare_Id { get; set; }
        public string Coach_Type { get; set; }
        public int Distance_From { get; set; }
        public int Distance_To { get; set; }
        public int Ticket_Amount { get; set; }
    }
}
