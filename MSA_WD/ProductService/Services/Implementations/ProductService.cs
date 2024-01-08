using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;
using ProductAPI.DTO;
using ProductAPI.Mapper;

namespace ProductAPI.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly ProductDbContext _context;

        public ProductService(ProductDbContext context)
        {
            _context = context;
        }
        public async Task<ProductDto> CreateUpdateProductAsync(ProductDto productDto)
        {
            var product=ModelConverter.DtoToModel(productDto);
            if (product.Id > 0)
            {
                _context.Products.Update(product);
            }
            else
            {
                _context.Products.Add(product);
            }
            await _context.SaveChangesAsync();
            var dtoProduct= ModelConverter.ModelToDto(product);
            return dtoProduct;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if(product == null)
            {
                return false;
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            var products = await _context.Products.Select((product) => ModelConverter.ModelToDto(product)).ToListAsync();
            return products;

        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.Where((product) => product.Id == id).Select((product) => ModelConverter.ModelToDto(product)).FirstOrDefaultAsync();
            return product;
        }
    }
}
