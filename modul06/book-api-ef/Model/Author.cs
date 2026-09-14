namespace Model
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Fullname { get; set; }
        public List<Book> Books { get; set; } //= new List<Book>(); // fix i git, problem hvis direkte anvendt
    }
}