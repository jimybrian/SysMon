using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SystemMonNETCore.Models;

namespace SystemMonNETCore.Hubs
{

    public class SysInfoHub : Hub
    {
        public SysInfoHub()
        {
        }

        static List<HubUsers> connUsers = new List<HubUsers>();

        public override Task OnConnectedAsync()
        {
            var us = new HubUsers();
            //Check if some user already connected
            var query = Context.GetHttpContext().Request.Query;
            us.userName = query["userName"];
            us.connectionId = Context.ConnectionId;
            var isUserConn = false;

            foreach (var u in connUsers)
                isUserConn = (u.userName.ToLower().Equals(us.userName.ToLower()));

            if (!isUserConn)
                connUsers.Add(us);

                return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            var usr = connUsers.Where(u => u.connectionId == Context.ConnectionId).FirstOrDefault();
            connUsers.Remove(usr);
            return base.OnDisconnectedAsync(exception);
        }

        public async Task SendSysInfo(SysInfoItem sysInfo)
        {
            try
            {
                await Clients.All.SendAsync("SendSysInfo", sysInfo);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                await Clients.Others.SendAsync("ERROR", "Cannot Send Data");
            }
        }

    }

    public class HubUsers
    {
        public string userName { get; set; }
        public string connectionId { get; set; }
    }
}

