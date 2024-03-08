using System.ComponentModel.DataAnnotations;

namespace OnlineRailwayReservationSystem.Models
{
    public class CancellationFees
    {
        [Key]
        public int CancellationFees_Id { get; set; }
        public int Cancellation_24Hours { get; set; }
        public int Cancellation_12Hours { get; set; }
        public int Cancellation_1Hours { get; set; }
    }
}
