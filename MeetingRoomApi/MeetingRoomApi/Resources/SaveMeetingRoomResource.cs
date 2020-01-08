using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoomApi.Resources
{
    public class SaveMeetingRoomResource
    {
       [Required]
       [MaxLength(6)]
        public int RoomNo { get; set; }

        [Required]
        [MaxLength(30)]
        public string RoomName { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int Capacity { get; set; }
        public string Accessories { get; set; }

        [Required]
        public char Status { get; set; }

        public string Area { get; set; }
        public string SubArea { get; set; }

        public char IsVCRoom { get; set; }

        public string IP_NO { get; set; }
    }
}
