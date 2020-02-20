using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Task_Web_Product.Controllers
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine(user);
            Console.WriteLine(message);
            
            await Clients.All.SendAsync("GotAMessage", user, message);
        }
    }
}