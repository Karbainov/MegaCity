namespace MegaCity.API.Models
{
    public class CheckOutputModel
    {
        public string Id { get; set; }

        public double Sum { get; set; }

        public List<ProductOutputModel> Products { get; set; }
    }
}
