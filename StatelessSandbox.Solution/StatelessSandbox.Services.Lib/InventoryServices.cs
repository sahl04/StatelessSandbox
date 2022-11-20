using StatelessSandbox.Services.Lib.Interfaces;

namespace StatelessSandbox.Services.Lib;

internal class InventoryServices : IInventoryServices
{
	public (int, bool) CreateInventoryEntry(int productId, int amount)
	{
		Console.WriteLine($"Inventory entry created: ProductId {productId} - Amount {amount}");
		return (1, true);
	}

	public bool DeleteInventoryEntry(int inventoryEntryId)
	{
		Console.WriteLine($"Inventory entry {inventoryEntryId} deleted");
		return true;
	}
}
