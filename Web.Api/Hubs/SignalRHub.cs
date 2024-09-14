using Microsoft.AspNetCore.SignalR;
using RestaurantManager.DataAccessLayer.Concrete;

namespace Web.Api.Hubs
{
	public class SignalRHub : Hub
	{
		RestaurantManagerContext context = new RestaurantManagerContext();
		public async Task SendCategoryCount()
		{
			var value = context.Categories.Count();
			await Clients.All.SendAsync("ReceiveCategoryCount", value);
		}
	}
}
