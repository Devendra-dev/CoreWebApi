using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeetingRoomApi.Domain.Models;
using MeetingRoomApi.Domain.IServices;
using MeetingRoomApi.Mapping;
using MeetingRoomApi.Resources;
using AutoMapper;
using MeetingRoomApi.Extensions;

namespace MeetingRoomApi.Controllers
{
    [Route("/api/[controller]")]
    public class MeetingRoomController : Controller
    {
        private readonly IMeetingRoomService _meetingRoomService;
        private readonly IMapper _mapper;

        public MeetingRoomController(IMeetingRoomService meetingRoomService, IMapper mapper)
        {
            _meetingRoomService = meetingRoomService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<MeetingRoomResource>> Rooms()
        {
            var Rooms = await _meetingRoomService.ListAync();
            var Resources = _mapper.Map<IEnumerable<Meeting_Room>, IEnumerable<MeetingRoomResource>>(Rooms);
            return Resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveMeetingRoomResource resource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }
            var Rooms = _mapper.Map<SaveMeetingRoomResource, Meeting_Room>(resource);
        }
    }
}