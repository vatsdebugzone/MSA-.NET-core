namespace ProductAPI.Services
{
    public interface IProductEntityService
    {
        Task<T> GetAllProducts<T>();
    }
}
