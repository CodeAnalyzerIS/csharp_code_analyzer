﻿using System.ComponentModel.DataAnnotations;

namespace CodeAnalyzerService.Backend.Dtos;

public class RuleViolationDto
{
    [Required] public RuleDto Rule { get; set; }
    [Required] public string PluginId { get; set; }
    [Required] public string Message { get; set; }
    [Required] public string TargetLanguage { get; set; }
    [Required] public LocationDto Location { get; set; }
    public string Severity { get; set; }
    
    public RuleViolationDto(RuleDto rule, string pluginId, string message, string targetLanguage, LocationDto location,
        string severity)
    {
        Rule = rule;
        PluginId = pluginId;
        Message = message;
        TargetLanguage = targetLanguage;
        Location = location;
        Severity = severity;
    }
}