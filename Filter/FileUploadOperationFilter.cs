namespace RpgCampanhas.Filter
{
    using Microsoft.OpenApi.Models;
    using Swashbuckle.AspNetCore.SwaggerGen;

    public class FileUploadOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation == null || context == null)
                return;

            // Verifica se o método tem um parâmetro do tipo IFormFile
            var fileParameter = context.MethodInfo.GetParameters()
                .FirstOrDefault(p => p.ParameterType == typeof(IFormFile));

            if (fileParameter != null)
            {
                operation.RequestBody = new OpenApiRequestBody
                {
                    Content = new Dictionary<string, OpenApiMediaType>
                    {
                        ["multipart/form-data"] = new OpenApiMediaType
                        {
                            Schema = new OpenApiSchema
                            {
                                Type = "object",
                                Properties =
                            {
                                ["file"] = new OpenApiSchema
                                {
                                    Type = "string",
                                    Format = "binary"
                                }
                            },
                                Required = new HashSet<string> { "file" }
                            }
                        }
                    }
                };
            }
        }
    }


}
