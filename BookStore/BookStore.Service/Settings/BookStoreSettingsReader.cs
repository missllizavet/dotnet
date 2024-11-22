namespace BookStore.Service.Settings
{
    public static class BookStoreSettingsReader
    {
        public static BookStoreSettings Read(IConfiguration configuration)
        {
            return new BookStoreSettings()
            {
                BookStoreDbContextConnectionString = configuration.GetValue<string>("BookStoreDbContext")
            };
        }
    }
}