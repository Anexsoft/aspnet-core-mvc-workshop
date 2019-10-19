namespace Model
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
