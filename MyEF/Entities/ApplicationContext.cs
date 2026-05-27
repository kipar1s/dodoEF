using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Personal> DbPersonal => Set<Personal>();
        //Автомотичсекое создание БД если она отсутствует
        public ApplicationContext() =>Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =D:\susu\modEF\dodoEF\dodoDb2.accdb ");
        }
    }
}
