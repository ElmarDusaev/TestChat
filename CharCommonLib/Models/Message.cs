using CharCommonLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatCommonLib.Models
{
    public class Message
    {
        public string SocketId { get; set; }
        public string MessageContent { get; set; }
        public string UserName { get; set; }
        public MessageType Type { get; set; }
        public List<ChatRoomUser> ChatRoomUsers { get; set; }
    }

}
