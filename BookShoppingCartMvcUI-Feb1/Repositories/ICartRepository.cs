namespace BookShoppingCartMvcUI
{
    public interface ICartRepository
    {
        Task<bool> AddItem(int bookId, int qty);
        Task<bool> RemoveItem(int bookId, int qty);
        Task<IEnumerable<ShoppingCart>> GetUserCart();
    }
}