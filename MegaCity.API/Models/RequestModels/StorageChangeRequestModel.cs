namespace MegaCity.API.Models.RequestModel
{
    public class StorageChangeRequestModel
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public string DataWriteOff { get; set; }

        public string ReasonWriteOff { get; set; }
    }
}
