namespace CarSaleProject.Entities
{
    public class Advertisement : BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public double Kilometers { get; set; }
        public string Trade { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int SalesManagerId { get; set; }
        public SalesManager SalesManager { get; set; }

    }
}
