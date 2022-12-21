namespace GeoProfs.Data
{
    public class DbInitializer
    {
        public static void Initialize(GeoProfsContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
