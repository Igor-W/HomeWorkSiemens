namespace HomeWorkSiemens.Models
{
    public class Step
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public List<Step> Steps { get; set; } = new List<Step>();

    }
}
