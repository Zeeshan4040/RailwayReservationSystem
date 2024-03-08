
using System.ComponentModel.DataAnnotations;

namespace OnlineRailwayReservationSystem.Models
{
    public class TrainScheduleMaster
    {
        [Key]
        public int Schedule_Id { get; set; }
        public string Schedule_Date { get; set; }
        public int Train_No { get; set; }
        public string Station_Code { get; set; }
        public int Distance { get; set; }
        public TimeSpan Arrival_Time { get; set; }
        public TimeSpan Departure_Time { get; set; }
        public int Day { get; set; }
    }
}
