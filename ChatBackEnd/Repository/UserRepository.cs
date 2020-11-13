using ChatBackEnd.Repository.Context;
using ChatBackEnd.Repository.Interfaces;
using ChatCommonLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBackEnd.Repository
{
    public class UserRepository : IUserRepositry
    {
        FakeDbContext context;

        public UserRepository(FakeDbContext context)
        {
            this.context = context;
        }

        public User Login(string login, string password)
        {
            return context.Users.Where(u => u.Login == login && u.Password == password && u.IsActive == true).FirstOrDefault();
        }
    }
}
