using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharCommonLib.Models
{
    public class ChatRoomUser: IComparable<ChatRoomUser>
    {
        public int Id { get; set; }
        public string SocketId { get; set; }
        public string Name { get; set; }

        public int CompareTo(ChatRoomUser other)
        {
            return this.SocketId.CompareTo(other.SocketId);
        }
    }
}
