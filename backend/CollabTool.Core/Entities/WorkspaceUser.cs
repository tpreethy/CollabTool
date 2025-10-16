
using CollabTool.Core.Enums;

namespace CollabTool.Core.Entities
{
    public class WorkspaceUser
    {
        public int Id { get; set; }
        public int WorkspaceId {  get; set; }
        public int UserId { get; set; }
        public WorkSpaceRole Role { get; set; } = WorkSpaceRole.Member;
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        //Navigation properties
        public Workspace Workspace { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
