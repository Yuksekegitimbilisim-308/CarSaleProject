namespace CarSaleProject.Models
{
    public class AdvertisementListModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }

        public string BrandName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public double Kilometers { get; set; }
        public string SalesManagerName { get; set; }
    }
}
