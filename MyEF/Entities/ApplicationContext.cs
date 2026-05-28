using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Personal> DbPersonal => Set<Personal>();
        public DbSet<Categori> Categori => Set<Categori>();
        public DbSet<Oder> Oder => Set<Oder>();
        //Автомотичсекое создание БД если она отсутствует
        public ApplicationContext() =>Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =D:\susu\modEF\dodoEF\dodoDb2.accdb ");
        }
    }
}
