using Sample_Web_API_Project.Model;
using Sample_Web_API_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Sample_Web_API_Project.Services
{
    public class ProductServices:IProductServices
    {

        private readonly IProductRepository _iProductRepo;
        public ProductServices(IProductRepository iProductRepo)
        {
            _iProductRepo = iProductRepo;
        }
        public int AddProduct(Product prod)
        {
            return _iProductRepo.AddProduct(prod);
        }
        public int DeleteProduct(int id)
        {
            return _iProductRepo.DeleteProduct(id);
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _iProductRepo.GetAllProducts();
        }
        public int ModifyProduct(Product prod)
        {
            return _iProductRepo.ModifyProduct(prod);
        }
    }
}
