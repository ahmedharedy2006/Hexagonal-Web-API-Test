using DOTNet9API.Domain.Entities;

namespace DOTNet9API.Domain.Interfaces
{
    public interface IProductRepo
    {
        Task<Product?> GetByIdAsync(Guid id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Guid id);
    }
}
