using System.ComponentModel.DataAnnotations;

namespace OnlineRailwayReservationSystem.Models
{
    public class ReservationFees
    {
        [Key]
        public int ReservationFees_Id { get; set; }
        public string Coach_Type { get; set; }
        public int Reservation_Fees { get; set; }
        public int Super_Fast_Fees { get; set; }

    }
}
