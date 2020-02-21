using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Task_Web_Product.Models;

namespace SignalR.SignalR
{
    public class ChatHub : Hub
    {
        public AppDbContext _AppDbContext;
        public ChatHub (AppDbContext _AppDBContext){
            _AppDbContext = _AppDBContext;
        }
        public async Task SendMessage(string user, string message)
        {
            Chat chat = new Chat {
                username = user,
                message = message
            };
            _AppDbContext.chats.Add(chat);
            await _AppDbContext.SaveChangesAsync();
            await Clients.All.SendAsync("GotAMessage", user, message);
        }
    }
}