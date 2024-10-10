namespace CarSaleProject.Entities
{
    public class Car : BaseEntity
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string CaseType { get; set; }
        public string FuelType { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<Advertisement> Advertisements { get; set; }
    }
}
