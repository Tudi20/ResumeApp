using Microsoft.AspNetCore.Components;

namespace ResumeApp.Models;

public record ResumeModel
{
    public required ResumeBasicsModel Basics { get; set; }
    public required List<ResumeEducationModel> Education { get; set; }
    public List<ResumeCertificationModel>? Certificates { get; set; }
    public required List<ResumeLanguageModel> Languages { get; set; }
    public ResumeSkillsModel? Skills { get; set; }
    public ResumeExperienceModel? Experience { get; set; }
    public List<string>? Hobbies { get; set; }
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

public record ResumeSkillsModel
{
    public List<string>? ProgrammingLanguages { get; set; }
    public List<string>? ProgrammingLanguagesImages { get; set; }
    public List<string>? Frameworks { get; set; }
    public List<string>? FrameworksImages { get; set; }
    public List<string>? VersionControl { get; set; }
    public List<string>? VersionControlImages { get; set; }
    public List<string>? DevelopmentEnvironments { get; set; }
    public List<string>? DevelopmentEnvironmentsImages { get; set; }
}

public record ResumeExperienceModel
{
    public string? Profession { get; set; }
    public string? Language { get; set; }
}