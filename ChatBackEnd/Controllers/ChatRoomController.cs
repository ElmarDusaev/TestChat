using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharCommonLib.Models;
using ChatBackEnd.Repository;
using ChatBackEnd.Repository.Interfaces;
using ChatCommonLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatRoomController : ControllerBase
    {
        IChatRoomRepository repositry;

        public ChatRoomController(IChatRoomRepository repositry)
        {
            this.repositry = repositry;
        }

        [HttpPost]
        public void Post(ChatRoomUser user)
        {
            repositry.Add(user);
        }

        [HttpGet]
        public List<ChatRoomUser> Get()
        {
            return repositry.GetAll();
        }

        [HttpDelete]
        public void Delete(string SocketId)
        {
            repositry.Remove(SocketId);
        }


    }
}
