using CharCommonLib.Models;
using ChatCommonLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBackEnd.Repository.Interfaces
{
    public interface IChatRoomRepository
    {
        void Add(ChatRoomUser user);
        List<ChatRoomUser> GetAll();
        void Remove(string socketId);
    }
}
