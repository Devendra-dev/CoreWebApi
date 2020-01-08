using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingRoomApi.Domain.Models;

namespace MeetingRoomApi.Domain.Service.Communication
{
    public class SaveMeetingRoomResponse : BaseResponse
    {
        public Meeting_Room Meeting_Room { get; private set; }

        private SaveMeetingRoomResponse(bool success,string message, )
        { 
        
        }
    }
}
