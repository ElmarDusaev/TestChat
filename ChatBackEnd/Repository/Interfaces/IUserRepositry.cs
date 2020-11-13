using ChatCommonLib.Models;
using System.Collections.Generic;

namespace ChatBackEnd.Repository.Interfaces
{
    public interface IUserRepositry
    {
        User Login(string login, string password);
    }
}