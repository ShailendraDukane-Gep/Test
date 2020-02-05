using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace demo1
{
    public class ApplicationHub : Hub
     { 
         public Task Send(string message){
             return Clients.All.SendAsync("Send", message);
         }
     }
}