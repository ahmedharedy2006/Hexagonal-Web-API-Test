using DOTNet9API.Application.DTOs;
using DOTNet9API.Domain.Entities;

namespace DOTNet9API.Application.Interfaces
{
    public interface IProductService
    {
        Task<Product?> GetByIdAsync(Guid id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task AddAsync(CreateProductRequest product);
        Task UpdateAsync(UpdateProductRequest product);
        Task DeleteAsync(Guid id);
    }
}
