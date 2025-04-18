using RpgCampanhas.Services.Interfaces;

namespace RpgCampanhas.Services
{
    public class FileStorageService : IFileStorageService
    {
        private readonly string _basePath;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public FileStorageService(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
            _basePath = configuration["StorageSettings:ImagesBasePath"];
        }

        public string GetEntityImagePath(string entityType)
        {
            return entityType.ToLower() switch
            {
                "personagem" => _configuration["StorageSettings:PersonagemImagesPath"],
                "ficha3det" => _configuration["StorageSettings:Ficha3detImagesPath"],
                "campanha" => _configuration["StorageSettings:CampanhaImagesPath"],
                "npc" => _configuration["StorageSettings:NpcImagesPath"],
                "local" => _configuration["StorageSettings:LocalImagesPath"],
                _ => throw new ArgumentException($"Tipo de entidade desconhecido: {entityType}")
            };
        }

        public async Task<string> SaveImageAsync(IFormFile imageFile, string entityId, string entityType)
        {
            // Obter o diretório específico para o tipo de entidade
            var entityPath = GetEntityImagePath(entityType);
            var directory = Path.Combine(_environment.ContentRootPath, _basePath, entityPath);

            // Verificar se o diretório existe, senão criar
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Gerar nome de arquivo único baseado no ID da entidade
            var fileExtension = Path.GetExtension(imageFile.FileName);
            var fileName = $"{entityType}_{entityId}_{Guid.NewGuid()}{fileExtension}";
            var filePath = Path.Combine(directory, fileName);

            // Salvar o arquivo
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }

            // Retornar caminho relativo para armazenar no banco de dados
            return $"/images/{entityPath}/{fileName}";
        }

        public void DeleteImage(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath))
                return;

            // Extrair o caminho relativo
            var relativePath = imagePath.TrimStart('/');
            var fullPath = Path.Combine(_environment.ContentRootPath, "wwwroot", relativePath);

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }
    }
}
