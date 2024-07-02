using DapperProject.Dtos.ProductDtos;

namespace DapperProject.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductWithCategoryDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(int id);
        Task<GetByIdProductDto> GetByIdProductAsync(int id);
    }
}
