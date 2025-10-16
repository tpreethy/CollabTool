namespace CollabTool.Core.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public int WorkspaceId { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.UtcNow;
        public bool IsEdited { get; set; } = false;

        //navigation poperties
        public Workspace Workspace { get; set; } = null!;
        public User User { get; set; } = null!;

    }
}
