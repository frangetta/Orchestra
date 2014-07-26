namespace Orchestra.DataLayer
{
    public class Division
    {
        public int DivisionId { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Priority { get; set; }

        public bool ShowMenu { get; set; }
        public bool Publish { get; set; }
    }
}