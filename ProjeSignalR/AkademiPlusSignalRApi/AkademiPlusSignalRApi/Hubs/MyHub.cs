using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkademiPlusSignalRApi.DAL;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

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
        
        public async Task SendName(string name)
        {
            if (Names.Count >= RoomCount)
            {
                await Clients.Caller.SendAsync("error", $"Bu odada en fazla {RoomCount} kişi olabilir.");
            }
            Names.Add(name);
            await Clients.All.SendAsync("receiveName", name);
        }
        public async Task GetNames()
        {
            await Clients.All.SendAsync("receiveNames", Names); // isim listesinin tümünü almak için yazdık.
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

        public async Task SendNameByGroup(string name, string roomName)
        {
            var room = _context.Rooms.FirstOrDefault(x => x.RoomName == roomName);
            if (room != null)
            {
                room.Users.Add(new User()
                {
                    UserName = name
                });
            }
            else
            {
                var newRoom = new Room(){RoomName = roomName};
                newRoom.Users.Add(new User(){UserName = name});
                _context.Rooms.Add(newRoom);
            }

            await _context.SaveChangesAsync();
            await Clients.Group(roomName).SendAsync("receiveMessageByGroup", name, room.RoomID);
        }

        public async Task GetNameByGroup()
        {
            var rooms = _context.Rooms.Include(x => x.Users).Select(y=> new
            {
                RoomID = y.RoomID,
                Users = y.Users.ToList()
            });
            await Clients.All.SendAsync("receiveNamesByGroup", rooms);
        }

        public async Task AddToGroup(string roomName) // grup oluşturmak için degil grubun içine birini eklemek için
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
        }

        public async Task RemoveFromGroup(string roomName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        }
    }
}
