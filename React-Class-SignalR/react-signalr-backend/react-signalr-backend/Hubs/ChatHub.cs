using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using react_signalr_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace react_signalr_backend.Hubs
{
    //[Authorize(HubRequirementDefaults.PolicyName)]
    public class ChatHub : Hub
    {
        public async Task SendToAll(ChatMessage message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }

        //public Task SendToAll(ChatMessage message)
        //{
        //    return Clients.All.SendAsync("ReceiveMessage", message);
        //}

    }
}
