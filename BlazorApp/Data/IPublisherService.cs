namespace BlazorApp.Data
{
    public interface IPublisherService
    {
        public void Seed();
        IList<Publisher>? GetPublishers();
        Publisher? GetPublisherById(int Id);
        void SavePublisher(Publisher publisher);
    }

}
