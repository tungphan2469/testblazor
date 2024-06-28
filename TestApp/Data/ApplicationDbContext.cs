using MongoDB.Driver;

namespace TestApp.Data
{
    public class ApplicationDbContext : IAccountantContext
    {
        public IMongoDatabase Database { get; set; }

        public ApplicationDbContext(IConfiguration config)
        {
            var dbname = new MongoUrl(config.GetConnectionString("DefaultConnection")).DatabaseName;
            var client = new MongoClient(config.GetConnectionString("DefaultConnection"));
            Database = client.GetDatabase(dbname);
        }
    }

    public interface IAccountantContext
    {
        IMongoDatabase Database { get; set; }
    }
}
