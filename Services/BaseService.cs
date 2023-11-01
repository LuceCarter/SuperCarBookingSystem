using MongoDB.Driver;
using SuperCarBookingSystem.Models;

namespace SuperCarBookingSystem.Services
{
    public class BaseService
    {
        public CarBookingDbContext _carBookingDbContext;

        public BaseService(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                _carBookingDbContext = scope.ServiceProvider.GetRequiredService<CarBookingDbContext>();
                if( _carBookingDbContext == null )
                {
                    throw new Exception("No Database Context");
                }                
            }
        }

        public IMongoDatabase Database(MongoDBSettings settings)
        {
            var client = new MongoClient(settings.AtlasURI);
            return client.GetDatabase(settings.DatabaseName);
        }
    }
}
