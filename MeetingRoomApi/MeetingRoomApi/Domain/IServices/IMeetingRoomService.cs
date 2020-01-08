using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingRoomApi.Domain.Models;

namespace MeetingRoomApi.Domain.IServices
{
   public interface IMeetingRoomService
    {
        Task<IEnumerable<Meeting_Room>> ListAync();
    }
}
