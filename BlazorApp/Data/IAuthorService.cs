namespace BlazorApp.Data
{
    public interface IAuthorService
    {
        void Seed();
        IList<Author>? GetAuthors();
        Author? GetAuthorById(int Id);
        DateTime GetCreationTime();
        void SaveAuthor(Author author); 
    }
}
