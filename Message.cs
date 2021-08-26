using System;
using System.Threading.Tasks;
using api_vanilla.model;
using Microsoft.AspNetCore.SignalR;

namespace api_vanilla
{

    public class MessageHub : Hub
    {
        public async Task SendMessage(NotifyMessage message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }

}