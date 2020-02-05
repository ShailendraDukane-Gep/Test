using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace demo1
{
	// Test1 story is under development
    public class ApplicationHub : Hub
     { 
         public Task Send(string message){
             return Clients.All.SendAsync("Send", "message");
         }
     }
}