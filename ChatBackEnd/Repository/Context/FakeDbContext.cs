using CharCommonLib.Models;
using ChatCommonLib.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBackEnd.Repository.Context
{
    public class FakeDbContext
    {
        private readonly static List<User> listUsers = new List<User>();
        private readonly static List<ChatRoomUser> listChatRoomUsers = new List<ChatRoomUser>();
        public FakeDbContext()
        {
            listUsers.Add(new User { Id = 1, Name = "Harry Potter", Login = "Harry", Password = "1", IsActive = true });
            listUsers.Add(new User { Id = 2, Name = "Ron Weasley", Login = "Ron", Password = "1", IsActive = true });
            listUsers.Add(new User { Id = 3, Name = "Hermione Granger", Login = "Her", Password = "1", IsActive = true });
        }


        public List<User> Users { get => listUsers; }
        public List<ChatRoomUser> ChatRoomUsers { get => listChatRoomUsers; }

    }
}
