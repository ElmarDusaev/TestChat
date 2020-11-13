using CharCommonLib.Models;
using ChatBackEnd.Repository.Context;
using ChatBackEnd.Repository.Interfaces;
using ChatBackEnd.WebSocketServer;
using ChatCommonLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChatBackEnd.Repository
{
    public class ChatRoomRepository : IChatRoomRepository
    {
        private readonly FakeDbContext context;
        private readonly ChatMessageHandler chatMessageHandler;

        public ChatRoomRepository(FakeDbContext context, ChatMessageHandler chatMessageHandler)
        {
            this.context = context;
            this.chatMessageHandler = chatMessageHandler;
        }

        public async void Add(ChatRoomUser user)
        {
            context.ChatRoomUsers.Add(user);
            await SendUpdateAsync();
        }
        public List<ChatRoomUser> GetAll()
        {
            return context.ChatRoomUsers;
        }

        public async void Remove(string socketId)
        {
            context.ChatRoomUsers.RemoveAll(x=>x.SocketId == socketId);
            await SendUpdateAsync();
        }

        private async Task SendUpdateAsync()
        {
            var message = new Message { ChatRoomUsers = GetAll(), Type = MessageType.Update };
            await chatMessageHandler.SendMessageToAllAsync(JsonSerializer.Serialize(message));
        }
    }
}
