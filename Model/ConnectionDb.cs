using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Task_19.Model.Data;
using Task_19.Model.Interface;

namespace Task_19.Model
{
    public class ConnectionDb : DbContext
    {
        private static bool _initialization;

        public ConnectionDb(string options) : base(options) 
        {
            if (!_initialization)
            {
                FillWithFalseData(new FalseData());

                _initialization = true;
            }

        }

        public void FillWithFalseData(IFalseData falseData)
        {
            if (DatabaseData.Count() < 1)
            {
                var _databaseData = falseData.GetFalsePersonalities();

                foreach (var item in _databaseData)
                {
                    DatabaseData.Add(item);
                }

                this.SaveChanges();
            }

            if (DatabasePersonalData.Count() < 1)
            {
                var _databasePersonalData = falseData.GetFalsePersonalData();

                foreach (var item in _databasePersonalData)
                {
                    DatabasePersonalData.Add(item);
                }

                this.SaveChanges();
            }  
        }

        public DbSet<Personalities> DatabaseData { get; set; }

        public DbSet<PersonalData> DatabasePersonalData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
