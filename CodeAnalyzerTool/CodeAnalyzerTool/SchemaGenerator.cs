using CAT_API.ConfigModel;
using Newtonsoft.Json.Schema.Generation;
using Serilog;
using Serilog.Events;

namespace CodeAnalyzerTool;

public static class SchemaGenerator
{
    public static async Task GenerateSchema()
    {
        Log.Warning("GENERATING SCHEMA!!!!!");
        Log.Write(LogEventLevel.Information, "I am testing this");
        var generator = new JSchemaGenerator();
        generator.GenerationProviders.Add(new StringEnumGenerationProvider());
        var schema = generator.Generate(typeof(GlobalConfig));
        await File.WriteAllTextAsync(StringResources.SchemaFileName, schema.ToString());
    }
}