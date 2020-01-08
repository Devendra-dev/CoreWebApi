using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingRoomApi.Domain.IServices;
using MeetingRoomApi.Domain.Models;
using MeetingRoomApi.Domain.Repositories;

namespace MeetingRoomApi.Domain.Service
{
    public class MeetingRoomService : IMeetingRoomService
    {
        private readonly IMeetingRoomRepository _meetingRoomRepository;

        public MeetingRoomService(IMeetingRoomRepository meetingRoomRepository)
        {
            _meetingRoomRepository = meetingRoomRepository;
        }
        public async Task<IEnumerable<Meeting_Room>> ListAync()
        {
           return await _meetingRoomRepository.ListAsync();
        }
    }
}
