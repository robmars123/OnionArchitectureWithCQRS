namespace API.Client.Models
{
    public class PostRequestModel
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public string? MessageTextRaw { get; set; }
    }
}
