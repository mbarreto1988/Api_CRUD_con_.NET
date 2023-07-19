using DemoTallerCodigoFacilito.Models;

namespace DemoTallerCodigoFacilito.Service
{
    public interface IProducService
    {
        void CreateProduct(ProductModels product);
        void DeleteProduct(int id);
        List<ProductEntity> GetAllProduct();
        ProductEntity GetProductId(int id);
    }
}