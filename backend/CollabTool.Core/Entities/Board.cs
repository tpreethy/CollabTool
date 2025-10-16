namespace CollabTool.Core.Entities
{
    public class Board
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int WorkspaceId { get; set; }
        public string ColorHex { get; set; } = "#0079BF";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //navigation properties

        public Workspace Workspace { get; set; } = null!;
        public ICollection<BoardList> BoardLists { get; set; }= new List<BoardList>();

    }
}
