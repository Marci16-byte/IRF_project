using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
