using Microsoft.AspNetCore.SignalR.Client;

namespace SysMonitorGUI.SysMon
{
    class DataSender
    {

        public HubConnection connection { get; set; }
       

        public DataSender(string url)
        {
            //connection = new HubConnection(url, "userName=winforms");                       
            connection = new HubConnectionBuilder().WithUrl(url + "?userName=winForms").Build();
        }


    }
}
