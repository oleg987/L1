namespace ConsoleApp14
{
    public class Author
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }

        public Author(string fullName, DateTime birthday)
        {
            FullName = fullName;
            Birthday = birthday;
        }
    }
}