namespace StatelessSandbox.Services.Lib.Interfaces;

public interface IInventoryServices
{
    (int, bool) CreateInventoryEntry(int productId, int amount);

    bool DeleteInventoryEntry(int inventoryEntryId);
}
