namespace SuperCarBookingSystem.Services
{
    public class DatabaseInitializationService
    {
        private IServiceProvider _serviceProvider;

        public DatabaseInitializationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Initialize()
        {
            using(var scope = _serviceProvider.CreateScope())
            {
                var _carBookingDbContext = scope.ServiceProvider.GetRequiredService<CarBookingDbContext>()!;
            }
        }
    }
}
