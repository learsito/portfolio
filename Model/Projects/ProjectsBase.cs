namespace ProjectsPages;

public class ProjectsBase {
    public string Id { get; set; } = "DefaultId";
    public string Title { get; set; } = "Project title";
    public string Image { get; set; } = "default.png";
    public string Description { get; set; } = "There should be a description here...";
    public string Href { get; set; } = "Projects";
    public bool NewTab { get; set; } = false;
}