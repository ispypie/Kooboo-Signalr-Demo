using Microsoft.AspNet.SignalR;

namespace ChatModule.Areas.ChatModule
{
	public class Chat : Hub
	{
		public void Send(string name, string message)
		{
			Clients.All.addMessage(name, message);
		}
	}
}