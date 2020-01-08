using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingRoomApi.Domain.Models;

namespace MeetingRoomApi.Domain.Repositories
{
   public interface IMeetingRoomRepository
    {
        Task<IEnumerable<Meeting_Room>> ListAsync();
    }
}
