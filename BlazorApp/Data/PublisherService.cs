using BlazorApp.Data;

namespace BlazorApp.Data

{
    public class PublisherService : IPublisherService
    {
        public List<Publisher>? publishers {get;set;}

        public void Seed()
        {
            publishers = new List<Publisher>();

            publishers.Add(new Publisher(1, "fatehi","casa"));
            publishers.Add(new Publisher(2, "mohamed2", "casa"));

        }

        public IList<Publisher>? GetPublishers()
        {
            return publishers;
        }

        public Publisher? GetPublisherById(int Id)
        {

            publishers ??= new List<Publisher>();


            return publishers.Where(x => x.Id == Id).FirstOrDefault();

        }
        
        public void SavePublisher(Publisher publisher)
        {
            publishers.Add(publisher);
        }
    }
}
