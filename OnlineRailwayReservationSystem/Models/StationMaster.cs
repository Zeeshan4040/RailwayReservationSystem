using System.ComponentModel.DataAnnotations;

namespace OnlineRailwayReservationSystem.Models
{
    public class StationMaster
    {
        [Key] public int Station_Id { get; set; }
        public string Station_Code { get; set; }
        public string Station_Name { get; set; }
        public string Station_Type { get; set; }
    }
}
