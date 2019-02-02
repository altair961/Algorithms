using System.Threading.Tasks;
using AlgorithmsPlayer.BubbleSort.Api.Models;
using Microsoft.AspNetCore.SignalR;

namespace AlgorithmsPlayer.BubbleSort.Api.Hubs
{
    public class ChatHub : Hub
    {
		public async Task SendMessage(ChatMessage message)
		{
			await Clients.All.SendAsync("ReceiveMessage", message);
		}
	}
}