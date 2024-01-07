using ProductAPI.DTO;

namespace ProductAPI.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProducts();
        Task<ProductDto> GetProductByIdAsync(int id);
        Task<ProductDto> CreateUpdateProductAsync(ProductDto product);
        Task<bool> DeleteProductAsync(int id);
    }
}
