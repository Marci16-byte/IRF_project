using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using SwimSocietyAdminApp.Persistence;

namespace SwimSocietyAdminApp.Model
{
    public class SwimmersModel : ModelAbstract
    {
        public SwimmersModel()
        {
            persistence = new SwimSocietyDataUtil();
            context = persistence.LoadDatabase();
        }

        public List<Swimmer> GetSwimmers()
        {
            return context.Swimmers.ToList();
        }

        public void AddNewSwimmer(string name, string birthplace, string birthtime, string sex, string age, string club)
        {
            try
            {
                Swimmer swim = new Swimmer();
                Club cl = context.Clubs.Where(c => c.Name == club).SingleOrDefault();
                if (cl != null)
                {
                    swim.Club_FK = cl.Id;
                } else
                {
                    Club newclub = new Club {Id = context.Clubs.ToList().Count+1, City="", Name=club, Prize=0, Swimmers=null };
                    context.Clubs.Add(newclub);
                    swim.Club_FK = newclub.Id;
                }

                swim.Id = context.Swimmers.ToList().Count+1;
                swim.AgeGroup_FK = GetNumFromAgeGroup(age); ;
                swim.Birthdate = DateTime.Parse(birthtime);
                swim.Birthplace = birthplace;
                swim.Name = name;
                swim.Sex = sex;

                context.Swimmers.Add(swim);
                context.SaveChangesAsync();
            }
            catch
            {
                throw new SwimSocietyDataException();
            }
        }

        public void ModifySwimmer(int id, string age, string birthplace, string birthtime, string club, string name, string sex)
        {
            try
            {
                var changed = context.Swimmers.Where(x => x.Id == id).FirstOrDefault();
                changed.AgeGroup_FK  = GetNumFromAgeGroup(age);
                changed.Birthdate    = DateTime.Parse(birthtime);
                changed.Birthplace   = birthplace;
                changed.Club_FK      = context.Clubs.Where(c => c.Name == club).FirstOrDefault().Id;
                changed.Name         = name;
                changed.Sex          = sex;

                context.SaveChanges();
            }
            catch
            {
                throw new SwimSocietyDataException();
            }
        }

        public void DeleteSwimmer(int id)
        {
            try
            {
                var deleted = context.Swimmers.Where(x => x.Id == id).FirstOrDefault();
                if(deleted != null)
                {
                    context.Swimmers.Remove(deleted);
                    context.SaveChanges();
                }
            }
            catch
            {
                throw new SwimSocietyDataException();
            }
        }

        public void DeleteSwimmersBy(string birthplace, string sex, string age, string club)
        {
            try
            {

                List<Swimmer> deleted = new List<Swimmer>();
                int ageGroup = age == "" ? 0 : int.Parse(age);
                int club_id = club == "" ? 0 : int.Parse(club);

                if (birthplace != "" && sex == "" && age == "" && club == "")
                {
                    deleted = context.Swimmers.Where(x => x.Birthplace == birthplace).ToList();
                }
                else if (birthplace == "" && sex != "" && age == "" && club == "")
                {
                    deleted = context.Swimmers.Where(x => x.Sex == sex).ToList();
                }
                else if (birthplace == "" && sex == "" && age != "" && club == "")
                {
                    deleted = context.Swimmers.Where(x => x.AgeGroup_FK == ageGroup).ToList();
                }
                else if (birthplace == "" && sex == "" && age == "" && club != "")
                {
                    deleted = context.Swimmers.Where(x => x.Club_FK == club_id).ToList();
                }
                else if (birthplace != "" && sex != "" && age == "" && club == "")
                {
                    deleted = context.Swimmers.Where(x => x.Birthplace == birthplace && x.Sex == sex).ToList();
                }
                else if (birthplace != "" && sex == "" && age != "" && club == "")
                {
                    deleted = context.Swimmers.Where(x => x.Birthplace == birthplace && x.AgeGroup_FK == ageGroup).ToList();
                }
                else if (birthplace != "" && sex == "" && age == "" && club != "")
                {
                    deleted = context.Swimmers.Where(x => x.Birthplace == birthplace && x.Club_FK == club_id).ToList();
                }
                else if (birthplace == "" && sex != "" && age != "" && club == "")
                {
                    deleted = context.Swimmers.Where(x => x.Sex == sex && x.AgeGroup_FK == ageGroup).ToList();
                }
                else if (birthplace == "" && sex != "" && age == "" && club != "")
                {
                    deleted = context.Swimmers.Where(x => x.Sex == sex && x.Club_FK == club_id).ToList();
                }
                else if (birthplace == "" && sex == "" && age != "" && club != "")
                {
                    deleted = context.Swimmers.Where(x => x.AgeGroup_FK == ageGroup && x.Club_FK == club_id).ToList();
                }
                else if (birthplace != "" && sex != "" && age != "" && club == "")
                {
                    deleted = context.Swimmers.Where(x => x.Birthplace == birthplace && x.Sex == sex &&  x.AgeGroup_FK == ageGroup).ToList();
                }
                else if (birthplace != "" && sex != "" && age == "" && club != "")
                {
                    deleted = context.Swimmers.Where(x => x.Birthplace == birthplace && x.Sex == sex && x.Club_FK == club_id).ToList();
                }
                else if (birthplace != "" && sex == "" && age != "" && club != "")
                {
                    deleted = context.Swimmers.Where(x => x.Birthplace == birthplace && x.AgeGroup_FK == ageGroup && x.Club_FK == club_id).ToList();
                }
                else if (birthplace == "" && sex != "" && age != "" && club != "")
                {
                    deleted = context.Swimmers.Where(x => x.Sex == sex && x.AgeGroup_FK == ageGroup && x.Club_FK == club_id).ToList();
                }
                else
                {
                    deleted = context.Swimmers.Where(x => x.Birthplace == birthplace && x.Sex == sex && x.AgeGroup_FK == ageGroup && x.Club_FK == club_id).ToList();
                }

                foreach (var item in deleted)
                {
                    context.Swimmers.Remove(item);
                }

                context.SaveChanges();
            }
            catch
            {
                throw new SwimSocietyDataException();
            }
        }

        public string GetSwimmerClub(int club)
        {
            return context.Clubs.Where(c => c.Id == club).FirstOrDefault().Name;
        }

        public AgeGroups GetAgeGroupFromNum(int age)
        {
            AgeGroups result = 0;
            switch (age)
            {
                case 1:
                    result = AgeGroups.Felnőtt;
                    break;
                case 2:
                    result = AgeGroups.Ifi;
                    break;
                case 3:
                    result = AgeGroups.Serdülő;
                    break;
                case 4:
                    result = AgeGroups.Gyermek;
                    break;
                case 5:
                    result = AgeGroups.Delfin;
                    break;
                case 6:
                    result = AgeGroups.Béka;
                    break;
                default:
                    break;
            }

            return result;
        }

        public int GetNumFromAgeGroup(string age)
        {
            int result = 0;

            if (AgeGroups.Felnőtt.ToString() == age) result = 1;
            else if (AgeGroups.Ifi.ToString() == age) result = 2;
            else if (AgeGroups.Serdülő.ToString() == age) result = 3;
            else if (AgeGroups.Gyermek.ToString() == age) result = 4;
            else if (AgeGroups.Delfin.ToString() == age) result = 5;
            else if (AgeGroups.Béka.ToString() == age) result = 6;

            return result;
        }
    }

    public class ClubsModel : ModelAbstract
    {
        public ClubsModel()
        {
            persistence = new SwimSocietyDataUtil();
            context = persistence.LoadDatabase();
        }

        public List<Club> GetClubs()
        {
            return context.Clubs.ToList();
        }

        public void ModifyClub(int id, string name, string city, string prize)
        {
            try
            {
                var changed = context.Clubs.Where(x => x.Id == id).FirstOrDefault();
                changed.Name = name;
                changed.City = city;
                changed.Prize = int.Parse(prize);

                context.SaveChanges();
            }
            catch
            {
                throw new SwimSocietyDataException();
            }
        }

        public void DeleteClub(int id)
        {
            try
            {
                var deleted = context.Clubs.Where(x => x.Id == id).FirstOrDefault();
                if (deleted != null)
                {
                    context.Clubs.Remove(deleted);
                    context.SaveChanges();
                }
            }
            catch
            {
                throw new SwimSocietyDataException();
            }
        }

        public void AddNewClub(string name, string city, string prize)
        {
            try
            {
                Club club = new Club();
                club.Id = context.Clubs.ToList().Count + 1;
                club.Name = name;
                club.City = city;
                club.Prize = int.Parse(prize);

                context.Clubs.Add(club);
                context.SaveChangesAsync();
            }
            catch
            {
                throw new SwimSocietyDataException();
            }
        }
    }

    public class StatsModel : ModelAbstract
    {
        public StatsModel()
        {
            persistence = new SwimSocietyDataUtil();
            context = persistence.LoadDatabase();
        }

        public Dictionary<string, int?> GetClubPrizes()
        {
            Dictionary<string, int?> result = new Dictionary<string, int?>();
            foreach (var item in context.Clubs)
            {
                result.Add(item.Name, item.Prize);
            }

            return result;
        }

        public Dictionary<string, int> GetClubSwimmers()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var item in context.Clubs.Include(x => x.Swimmers))
            {
                result.Add(item.Name + " - " + item.Swimmers.Count.ToString(), item.Swimmers.Count);
            }

            return result;
        }
    }
}
