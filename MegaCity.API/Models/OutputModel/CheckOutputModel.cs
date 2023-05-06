namespace MegaCity.API.Models.OutputModel
{
    public class CheckOutputModel
    {
        public string Id { get; set; }

        public double Sum { get; set; }

        public List<ProductOutputModel> Products { get; set; }
    }
}
