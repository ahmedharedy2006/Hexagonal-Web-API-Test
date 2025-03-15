using DOTNet9API.Application.DTOs;
using DOTNet9API.Application.Interfaces;
using DOTNet9API.Domain.Entities;
using DOTNet9API.Domain.Interfaces;

namespace DOTNet9API.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo) {
            
            _productRepo = productRepo;

        }

        public async Task AddAsync(CreateProductRequest request)
        {
            var existingProducts = await _productRepo.GetAllAsync();

            if (existingProducts.Any(p => p.Name == request.Name))
            {
                throw new InvalidOperationException("Product name must be unique.");
            }

            var product = new Product(request.Name,request.Description, request.Price, request.Stock);

            await _productRepo.AddAsync(product);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _productRepo.DeleteAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _productRepo.GetAllAsync();
        }

        public async Task<Product?> GetByIdAsync(Guid id)
        {
            return await _productRepo.GetByIdAsync(id);

        }

        public async Task UpdateAsync(UpdateProductRequest request)
        {
            var product = new Product(request.Name, request.Description, request.Price, request.Stock);

            await _productRepo.UpdateAsync(product);
        }
    }
}
