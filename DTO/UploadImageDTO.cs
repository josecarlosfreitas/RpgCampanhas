namespace RpgCampanhas.DTO
{
    public class UploadImageDTO
    {
        public string EntityType { get; set; }
        public string EntityId { get; set; }
        public IFormFile File { get; set; }
    }

}
