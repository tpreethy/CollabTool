
namespace CollabTool.Core.Entities
{
    public class BoardList
    {
        public int Id;
        public string Title { get; set; } = string.Empty;
        public int BoardId { get; set; }
        public int Position { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //Navigation properties

        public Board Board { get; set; } = null!;
        public ICollection<TaskCard> TaskCards { get; set; } = new List<TaskCard>();
    }
}
