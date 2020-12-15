namespace SwimSocietyAdminApp.Persistence
{
    public interface ISwimSocietyDataBase
    {
        SwimSocietyDB LoadDatabase();
    }

    public class SwimSocietyDataUtil : ISwimSocietyDataBase
    {
        public SwimSocietyDB LoadDatabase()
        {
            return new SwimSocietyDB();
        }
    }
}
