namespace StatelessSandbox.Services.Lib.Interfaces;

internal interface INotifierServices
{
    (int, bool) CreateNotifierEntry(int productId, int amount);
    bool DeleteNotifierEntry(int notifierEntryId);
}