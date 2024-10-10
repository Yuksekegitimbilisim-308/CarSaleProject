namespace CarSaleProject.Entities
{
    public class SalesManager : BaseEntity
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Advertisement> Advertisements { get; set; }
    }
}
