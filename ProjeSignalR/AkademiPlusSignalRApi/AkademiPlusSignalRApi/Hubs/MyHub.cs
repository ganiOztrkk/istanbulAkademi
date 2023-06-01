using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AkademiPlusSignalRApi.DAL;
using Microsoft.AspNetCore.SignalR;

namespace AkademiPlusSignalRApi.Hubs
{
    public class MyHub : Hub
    {
        public static List<string> Names { get; set; } = new List<string>(); // kişilerimi yani user'ları tutacak olan liste. names e atama gerçekleştirebilmek için default olarak nesne türettik. 
        public static int ClientCount { get; set; } = 0; // biz o anda kaç farklı istemciden istek atıyoruz bunu gösterecek

        public static int RoomCount { get; set; } = 5; // odadaki kişi sayısı olacak - bir odada en fazla kaç kişi olacak bunu tutucaz
        private readonly Context _context;

        public MyHub(Context context)
        {
            _context = context;
        }

        public async Task sendName(string name)
        {
            Names.Add(name);
            await Clients.All.SendAsync("receiveName", name);
        }

        public override async Task OnConnectedAsync()
        {
            ClientCount++; 
            await Clients.All.SendAsync("receiveClientCount", ClientCount);
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            ClientCount--;
            await Clients.All.SendAsync("receiveClientCount", ClientCount);
        }
    }
}
