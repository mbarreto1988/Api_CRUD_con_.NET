using DemoTallerCodigoFacilito.Data;
using DemoTallerCodigoFacilito.Models;

namespace DemoTallerCodigoFacilito.Service
{
    public class ProducService : IProducService
    {
        private readonly StoreDbContext _context;
        public ProducService(StoreDbContext context)
        {
            this._context = context;
        }

        public void CreateProduct(ProductModels product)
        {
            ProductEntity productEntity = new()
            {
                Name = product.Name,
                Descripcion = product.Descripcion,
                Stock = product.Stock,
                CreateData = DateTime.Now
            };
            _context.Products.Add(productEntity);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            ProductEntity productToDelete = this.GetProductId(id);
            _context.Products.Remove(productToDelete);
            _context.SaveChanges();
        }

        public ProductEntity GetProductId(int id)
        {
            return _context.Products.Find(id);
        }

        public List<ProductEntity> GetAllProduct()
        {
            return _context.Products.ToList();
        }
    }
}
