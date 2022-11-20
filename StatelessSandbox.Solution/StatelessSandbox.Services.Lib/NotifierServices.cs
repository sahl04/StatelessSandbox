using StatelessSandbox.Services.Lib.Interfaces;

namespace StatelessSandbox.Services.Lib;

internal class NotifierServices : INotifierServices
{
	public (int, bool) CreateNotifierEntry(int productId, int amount)
	{
		Console.WriteLine($"Order for {amount} times of product {productId} processed");
		return (1, true);
	}

	public bool DeleteNotifierEntry(int notifierEntryId)
	{
		Console.WriteLine($"Inventory entry {notifierEntryId} deleted");
		return true;
	}
}
