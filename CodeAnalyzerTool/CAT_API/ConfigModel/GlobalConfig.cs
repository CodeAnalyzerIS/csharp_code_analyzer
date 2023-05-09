using Newtonsoft.Json;

namespace CAT_API.ConfigModel;

public class GlobalConfig
{
    // todo update Config wiki page
    [JsonProperty("apiUrl", Required = Required.Always)]
    public string ApiUrl { get; set; }

    [JsonProperty("pluginsPath", Required = Required.Always)]
    public string PluginsPath { get; set; }

    [JsonProperty("builtInPlugins", Required = Required.Always)]
    public IEnumerable<PluginConfig> BuiltInPlugins { get; set; }

    [JsonProperty("plugins", Required = Required.Always)]
    public IEnumerable<PluginConfig> ExternalPlugins { get; set; }

    public GlobalConfig(string apiUrl, string pluginsPath, IEnumerable<PluginConfig> builtInPlugins,
        IEnumerable<PluginConfig> externalPlugins)
    {
        ApiUrl = apiUrl;
        PluginsPath = pluginsPath;
        BuiltInPlugins = builtInPlugins;
        ExternalPlugins = externalPlugins;
    }
}