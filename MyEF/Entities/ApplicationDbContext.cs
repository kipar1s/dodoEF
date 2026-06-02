using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace dodoEF.MyEF.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Personal> DbPersonal => Set<Personal>();
        public DbSet<Categori> Categori => Set<Categori>();
        public DbSet<Oder> Oder => Set<Oder>();
        public DbSet<Client> Client => Set<Client>();
        public DbSet<Ingr> Ingr => Set<Ingr>();
        public DbSet<Tovar> Tovar => Set<Tovar>();
        public DbSet<Plateg> Plateg => Set<Plateg>();
        public DbSet<Evelobilitile> Evelobilitile => Set<Evelobilitile>();
        public DbSet<OderTovar> OrderTovars => Set<OderTovar>();
        public DbSet<TovarIngr> TovarIngrs => Set<TovarIngr>();
        public DbSet<PersonalEvelobilitile> PersonalEvelobilitile => Set<PersonalEvelobilitile>();
        public DbSet<User> Users => Set<User>();


        //Автомотичсекое создание БД если она отсутствует
        public ApplicationDbContext() =>Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Получаем путь к директории, где находится исполняемый файл
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Поднимаемся на 3 уровня вверх (из bin/Debug/net8.0-windows в корень проекта)
            string projectRoot = Path.Combine(baseDirectory, "..", "..", "..");
            string dbPath = Path.GetFullPath(Path.Combine(projectRoot, "dodoDb2.accdb"));
            
            optionsBuilder.UseJet($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Составные первичные ключи для промежуточных таблиц
            modelBuilder.Entity<OderTovar>()
                .HasKey(ot => new { ot.OderId, ot.TovarId });

            modelBuilder.Entity<TovarIngr>()
                .HasKey(ti => new { ti.TovarId, ti.IngrId });

            modelBuilder.Entity<PersonalEvelobilitile>()
                .HasKey(pe => new { pe.PersonalId, pe.EvelobilitileId });

            // Связь один-к-одному между Oder и Plateg
            modelBuilder.Entity<Oder>()
                .HasOne(o => o.plategs)
                .WithOne(p => p.Oder)
                .HasForeignKey<Oder>(o => o.plategid)
                .OnDelete(DeleteBehavior.Cascade);

            // Уникальность внешнего ключа plategid (чтобы один платёж не попал в два заказа)
            modelBuilder.Entity<Oder>()
                .HasIndex(o => o.plategid)
                .IsUnique();

            // Остальные связи настраиваются автоматически по соглашениям,
            // но для ясности можно прописать:
            modelBuilder.Entity<Oder>()
                .HasOne(o => o.client)
                .WithMany(c => c.oders)
                .HasForeignKey(o => o.clientId);

            modelBuilder.Entity<Oder>()
                .HasOne(o => o.personal)
                .WithMany(p => p.oders)
                .HasForeignKey(o => o.personalId);

            modelBuilder.Entity<Personal>()
                .HasOne(p => p.categori)
                .WithMany(c => c.Personals)
                .HasForeignKey(p => p.categoriId);

            // Настройка многих-ко-многим через явные классы уже задана через DbSet и ключи
        }
    }
}
