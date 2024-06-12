using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;


namespace MyLibrarySpace.Extensions;

/// <summary>
/// Расширения для настроек Swagger
/// </summary>
public static class SwaggerGenOptionsExtensions
{
    /// <summary>
    /// Маппер для <see cref="DateOnly"/> в строку
    /// </summary>
    public static void UseDateOnlyStringConverters(this SwaggerGenOptions options)
    {
        options.MapType<DateOnly>(() => new OpenApiSchema
        {
            Type = "string",
            Format = "date"
        });
    }
}