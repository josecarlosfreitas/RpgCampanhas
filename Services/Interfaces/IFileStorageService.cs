namespace RpgCampanhas.Services.Interfaces
{
    public interface IFileStorageService
    {
        Task<string> SaveImageAsync(IFormFile imageFile, string entityId, string entityType);
        void DeleteImage(string imagePath);
        string GetEntityImagePath(string entityType);
    }
}
