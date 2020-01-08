using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingRoomApi.Domain.Models;
using MeetingRoomApi.Domain.Repositories;
using MeetingRoomApi.Persistance.Repositories;
using MeetingRoomApi.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MeetingRoomApi.Persistance.Repositories
{
    public class MeetingRoomRepository : BaseRepository, IMeetingRoomRepository
    {
        public MeetingRoomRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }
        public async Task<IEnumerable<Meeting_Room>> ListAsync()
        {
            return await _appDbContext.Meeting_Room.ToListAsync();
        }
    }
}
