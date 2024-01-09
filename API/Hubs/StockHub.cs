using Microsoft.AspNetCore.SignalR;

public class StockHub : Hub
{
    public async Task SendStockPrice(int stockId, decimal price)
    {
        await Clients.All.SendAsync("ReceiveStockPrice", stockId, price);
    }
}