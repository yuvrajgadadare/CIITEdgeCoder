namespace CIITEdge.Models
{
    public class TutorialModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; // e.g., Basics, OOP, Advanced
        public string ShortDescription { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string CodeSnippet { get; set; } = string.Empty;
    }
}
