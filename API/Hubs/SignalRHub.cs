using Microsoft.AspNetCore.SignalR;
using DataAccessLayer.Concrete;

namespace Api.Hubs
{
	public class SignalRHub: Hub
	{
	   SignalRContext context = new SignalRContext();
		public async Task SendCategoryCount()
		{
			var value=context.Categories.Count();
			await Clients.All.SendAsync("ReceiverCategoryCount", value);

		}



	}
}
