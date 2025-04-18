namespace RpgCampanhas.Repositories.Interfaces
{
    public interface IGenericRepository
    {
        Task UpdatePersonagemImageAsync(string personagemId, string imagePath);
        Task UpdateFicha3detImageAsync(string sheetId, string imagePath);
        Task UpdateCampanhaImageAsync(string campanhaId, string imagePath);
        Task UpdateNpcImageAsync(string npcId, string imagePath);
        Task UpdateLocalImageAsync(string localId, string imagePath);
    }
}
