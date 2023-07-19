namespace DemoTallerCodigoFacilito.Models
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Descripcion { get; set; }
        public int Stock { get; set; }
        public DateTime CreateData { get; set; }
    }
}
