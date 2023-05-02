using Newtonsoft.Json;

namespace CodeAnalyzerTool.ConfigModel;

public class RuleConfig
{
    [JsonProperty("ruleName", Required = Required.Always)]
    public string RuleName { get; set; }
    
    [JsonProperty("enabled", Required = Required.Always)]
    public bool Enabled { get; set; }
    
    [JsonProperty("options")]
    public Dictionary<string, string> Options { get; set; }

    public RuleConfig(string ruleName, bool enabled, Dictionary<string, string> options)
    {
        RuleName = ruleName;
        Enabled = enabled;
        Options = options;
    }
}