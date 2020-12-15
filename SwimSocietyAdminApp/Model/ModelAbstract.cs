using SwimSocietyAdminApp.Persistence;

namespace SwimSocietyAdminApp.Model
{
    public abstract class ModelAbstract
    {
        public enum AgeGroups { Felnőtt = 1, Ifi, Serdülő, Gyermek, Delfin, Béka }
        public SwimSocietyDataUtil persistence;
        public SwimSocietyDB context;
    }
}
