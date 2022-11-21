using Microsoft.AspNetCore.Components;

namespace ResumeApp.Models;

public record ResumeModel
{
    public required ResumeBasicsModel Basics { get; set; }
    public required List<ResumeEducationModel> Education { get; set; }
    public List<ResumeCertificationModel>? Certificates { get; set; }
    public required List<ResumeLanguageModel> Languages { get; set; }
}

public record ResumeBasicsModel
{
    public required string Name { get; set; }
    public required string Label { get; set; }
    public string? Picture { get; set; }
    public string? Email { get; set; }
    public DateOnly BirthDate { get; set; }
}

public record ResumeEducationModel
{
    public required string School { get; set; }
    public required string Degree { get; set; }
    public bool Graduated { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public string? Description { get; set; }
}

public record ResumeCertificationModel
{
    public required string Name { get; set; }
    public required DateOnly Date { get; set; }
    public required string Issuer { get; set; }
}

public record ResumeLanguageModel
{
    public required string Name { get; set; }
    public required string Level { get; set; }
    public required string Emoji { get; set; }
}