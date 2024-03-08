using System.ComponentModel.DataAnnotations;

namespace OnlineRailwayReservationSystem.Models
{
    public class TrainMaster
    {
        [Key] public int Train_Id { get; set; }
        public int Train_No { get; set; }
        public string Train_Name { get; set; }
        public string Train_Type { get; set; }
        public string? Schedule_Mon { get; set; }
        public string? Schedule_Tue { get; set; }
        public string? Schedule_Wed { get; set; }
        public string? Schedule_Thu { get; set; }
        public string? Schedule_Fri { get; set; }
        public string? Schedule_Sat { get; set; }
        public string? Schedule_Sun { get; set; }
        public int Coach_A1 { get; set; }
        public int Coach_A2 { get; set; }
        public int Coach_A3 { get; set; }
        public int Coach_SL { get; set; }
        public int Coach_GN { get; set; }

    }
}
