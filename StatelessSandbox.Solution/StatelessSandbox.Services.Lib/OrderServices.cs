using StatelessSandbox.Services.Lib.Interfaces;

namespace StatelessSandbox.Services.Lib;

public class OrderServices : IOrderServices
{
	public (int, bool) CreateOrder(int productId, int amount)
	{
		Console.WriteLine($"Order created: ProductId {productId} - Amount {amount}");
		return (1, true);
	}

	public bool DeleteOrder(int orderId)
	{
		Console.WriteLine($"Order {orderId} deleted");
		return true;
	}
}
