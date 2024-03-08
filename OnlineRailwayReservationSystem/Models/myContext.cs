using Microsoft.EntityFrameworkCore;

namespace OnlineRailwayReservationSystem.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base (options)
        {

        }
        public DbSet<StationMaster> tbl_StationMaster { get; set; }
        public DbSet<TrainMaster> tbl_TrainMaster { get; set; }
        public DbSet<TrainScheduleMaster> tbl_TrainScheduleMaster { get; set; }
        public DbSet<FareRule> tbl_FareRule { get; set; }
        public DbSet<CancellationFees> tbl_CancellationFees { get; set; }
        public DbSet<ReservationFees> tbl_ReservationFees { get; set; }
    }
}
