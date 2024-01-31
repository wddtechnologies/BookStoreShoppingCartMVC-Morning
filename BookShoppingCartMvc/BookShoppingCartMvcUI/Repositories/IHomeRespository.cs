namespace BookShoppingCartMvcUI
{
    public interface IHomeRespository
    {
        Task<IEnumerable<Book>> GetBooks(string sTerm = "", int genreId = 0);

    }
}