namespace StatelessSandbox.Services.Lib.Interfaces;

public interface IOrderServices
{
    (int, bool) CreateOrder(int productId, int amount);
    bool DeleteOrder(int orderId);
}