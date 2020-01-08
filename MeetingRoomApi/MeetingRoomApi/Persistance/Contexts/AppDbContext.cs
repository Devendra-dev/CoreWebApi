using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingRoomApi.Domain.Models;

namespace MeetingRoomApi.Persistance.Contexts
{
    public class AppDbContext :DbContext
    {
        public DbSet<Meeting_Room> Meeting_Room { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Meeting_Room>().ToTable("Meeting_Room");
            builder.Entity<Meeting_Room>().HasKey(Room => Room.RoomId);
            builder.Entity<Meeting_Room>().Property(Room => Room.RoomId).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Meeting_Room>().Property(Room => Room.RoomNo).IsRequired();
            builder.Entity<Meeting_Room>().Property(Room => Room.RoomName).IsRequired();

            builder.Entity<Meeting_Room>().HasData(
                new Meeting_Room { RoomId = 1001, RoomNo = 1, RoomName = "DevMeetingRoom" },
                new Meeting_Room { RoomId = 1002, RoomNo = 2, RoomName = "YadavMeetingRoom" }
                );
        }

    }
}
