
namespace CollabTool.Core.Entities
{
    public class Workspace
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int OwnerId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //navigation properties
        public User Owner { get; set; } = null!;
        public ICollection<WorkspaceUser> WorkspaceUsers { get; set; } = new List<WorkspaceUser>();
        public ICollection<Board> Boards { get; set; } = new List<Board>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();

    }
}
