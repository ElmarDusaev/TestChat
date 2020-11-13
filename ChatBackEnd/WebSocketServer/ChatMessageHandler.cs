using ChatBackEnd.Repository;
using ChatBackEnd.Repository.Interfaces;
using ChatCommonLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ChatBackEnd.WebSocketServer
{



    public class ChatMessageHandler : WebSocketHandler
    {

        public ChatMessageHandler(ConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager)
        {
        }

        public async override Task OnConnected(WebSocket socket)
        {
            await base.OnConnected(socket);
            var socketId = WebSocketConnectionManager.GetId(socket);
            await SendMessageToAllAsync(JsonSerializer.Serialize(new Message { SocketId = socketId, Type = MessageType.Connect}));
        }

        public override async Task ReceiveAsync(WebSocket socket, WebSocketReceiveResult result, byte[] buffer)
        {
            var socketId = WebSocketConnectionManager.GetId(socket);
            var message = JsonSerializer.Deserialize<Message>(Encoding.UTF8.GetString(buffer, 0, result.Count));
            message.SocketId = socketId;
            //message.Type = MessageType.Message;
            string jsonmessage = JsonSerializer.Serialize(message); ;
            Console.WriteLine(jsonmessage);
            await SendMessageToAllAsync(jsonmessage);
        }

    }
}
