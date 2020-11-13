using CharCommonLib.Models;
using ChatCommonLib.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Utils
{
    public static class ApiRestUtils
    {
        public static User Auth(string Login, string Password)
        {
            var client = new RestClient($"{ConfigurationManager.AppSettings["ApiServer"]}/api/auth");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { Login, Password });
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                var user = JsonConvert.DeserializeObject<User>(response.Content);
                return user;
            }

            return null;
        }


        public static void UserConnected(User user)
        {
            var client = new RestClient($"{ConfigurationManager.AppSettings["ApiServer"]}/api/chatroom");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new ChatRoomUser { SocketId = user.SocketId, Name = user.Name, Id = user.Id });
            IRestResponse response = client.Execute(request);

        }


        public static void UserDisConnected(User user)
        {
            var client = new RestClient($"{ConfigurationManager.AppSettings["ApiServer"]}/api/chatroom");
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            request.AddParameter("SocketId", user.SocketId);
            client.Execute(request);

        }

    }
}
