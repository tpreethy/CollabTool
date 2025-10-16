
using CollabTool.Core.Enums;

namespace CollabTool.Core.Entities
{
    public class TaskCard
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int BoardListId { get; set; }
        public int Position { get; set; }
        public int? AssignedToUserId { get; set; }
        public Priority Priority { get; set; } = Priority.Medium;
        public DateTime? DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        //Navigation Properties

        public BoardList BoardList { get; set; } = null!;
        public User? AssignedTo { get; set; }

    }
}
