namespace BasketApi.Repositories;

public class BasketRepository(IDocumentSession Session) : IBasketRepository
{
    public async Task<ShoppingCart> GetBasket(string userName, CancellationToken cancellationToken = default)
    {
        var basket = await Session.LoadAsync<ShoppingCart>(userName, cancellationToken);
        return basket is null ? throw new BasketNotFoundException(userName) : basket;
    }

    public async Task<ShoppingCart> StoreBasket(ShoppingCart basket, CancellationToken cancellationToken = default)
    {
        Session.Store(basket);
        await Session.SaveChangesAsync(cancellationToken);
        return basket;
    }

    public async Task<bool> DeleteBasket(string userName, CancellationToken cancellationToken = default)
    {
        Session.Delete<ShoppingCart>(userName);
        await Session.SaveChangesAsync(cancellationToken);
        return true;
    }

}
