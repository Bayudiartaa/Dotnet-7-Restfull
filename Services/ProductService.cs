namespace WebApi.Services;

using AutoMapper;
using WebApi.Entities;
using WebApi.Models.Product;
using WebApi.Repositories;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAll();
    Task<Product> GetById(int id);
    Task Create(CreateRequest model);
    Task Update(int id, UpdateRequest model);
    Task Delete(int id);
}

public class ProductService : IProductService
{    
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await _productRepository.GetAll();
    }

    public async Task<Product> GetById(int id)
    {
        var product = await _productRepository.GetById(id);

        if (product == null)
            throw new KeyNotFoundException("Product not found");

        return product;
    }

    public async Task Create(CreateRequest model)
    {

        // map model to new product object
        var product = _mapper.Map<Product>(model);

        // save product
        await _productRepository.Create(product);
    }

    public async Task Update(int id, UpdateRequest model)
    {
        var product = await _productRepository.GetById(id);

        if (product == null)
            throw new KeyNotFoundException("Product not found");

        _mapper.Map(model, product);

        // save product
        await _productRepository.Update(product);
    }

    public async Task Delete(int id)
    {
        await _productRepository.Delete(id);
    }
}