using Microsoft.AspNetCore.Mvc;
using RpgCampanhas.DTO;
using RpgCampanhas.Repositories.Interfaces;
using RpgCampanhas.Services.Interfaces;

[ApiController]
[Route("api/[controller]")]
public class ImageController : ControllerBase
{
    private readonly IFileStorageService _fileStorageService;
    private readonly IGenericRepository _repository;

    public ImageController(IFileStorageService fileStorageService, IGenericRepository repository)
    {
        _fileStorageService = fileStorageService;
        _repository = repository;
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadImage([FromForm] UploadImageDTO uploadImageDTO)
    {
        if (uploadImageDTO.File == null || uploadImageDTO.File.Length == 0)
            return BadRequest("Nenhum arquivo foi enviado.");

        var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
        var extension = Path.GetExtension(uploadImageDTO.File.FileName).ToLowerInvariant();

        if (!allowedExtensions.Contains(extension))
            return BadRequest("Tipo de arquivo não permitido.");

        if (uploadImageDTO.File.Length > 5 * 1024 * 1024)
            return BadRequest("O arquivo não pode ser maior que 5MB.");

        var validEntityTypes = new[] { "personagem", "ficha3det", "campanha", "npc" };
        if (!validEntityTypes.Contains(uploadImageDTO.EntityType.ToLower()))
            return BadRequest($"Tipo de entidade inválido. Tipos válidos: {string.Join(", ", validEntityTypes)}");

        try
        {
            // Salvar a imagem e obter o caminho
            var imagePath = await _fileStorageService.SaveImageAsync(uploadImageDTO.File, uploadImageDTO.EntityId, uploadImageDTO.EntityType);

            // Atualizar a entidade com o novo caminho da imagem
            switch (uploadImageDTO.EntityType.ToLower())
            {
                case "personagem":
                    await _repository.UpdatePersonagemImageAsync(uploadImageDTO.EntityId, imagePath);
                    break;
                case "ficha3det":
                    await _repository.UpdateFicha3detImageAsync(uploadImageDTO.EntityId, imagePath);
                    break;
                case "campanha":
                    await _repository.UpdateCampanhaImageAsync(uploadImageDTO.EntityId, imagePath);
                    break;
                case "npc":
                    await _repository.UpdateNpcImageAsync(uploadImageDTO.EntityId, imagePath);
                    break;
            }

            return Ok(new { imagePath });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao processar o upload: {ex.Message}");
        }
    }

}