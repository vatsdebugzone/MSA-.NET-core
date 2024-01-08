using ProductAPI.DTO;
using ProductAPI.Entities;

namespace ProductAPI.Mapper
{
    public static class ModelConverter
    {
        public static Product DtoToModel(ProductDto model)
        {
            return new Product
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Price = model.Price,
                CategoryId = model.CategoryId
            };
        }
        public static ProductDto ModelToDto(Product model)
        {
            return new ProductDto
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Price = model.Price,
                CategoryId = model.CategoryId
            };
        }
    }
}
