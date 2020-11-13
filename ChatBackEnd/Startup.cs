using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ChatBackEnd.Repository;
using ChatBackEnd.Repository.Context;
using ChatBackEnd.Repository.Interfaces;
using ChatBackEnd.WebSocketServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebSockets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ChatBackEnd
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<FakeDbContext>();
            services.AddTransient<IUserRepositry, UserRepository>();
            services.AddTransient<IChatRoomRepository, ChatRoomRepository>();
            services.AddWebSocketManager();
            services.AddMvc();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var serviceScopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            var serviceProvider = serviceScopeFactory.CreateScope().ServiceProvider;

            app.UseWebSockets();
            app.MapWebSocketManager("/ws", serviceProvider.GetService<ChatMessageHandler>());
            app.UseStaticFiles();

            app.UseRouting();
            app.UseEndpoints(endpoint => {
                endpoint.MapDefaultControllerRoute();
            });


        }

    }
}
