namespace infraestructure
{
  
    using domain.entities.countries; 
    using domain.entities.persons;

    using Microsoft.EntityFrameworkCore;
   

    public class CountryDBContext : DbContext 
    {
        public CountryDBContext (DbContextOptions<CountryDBContext> options) : base (options) { }
        
  
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Person> Persons { get; set; } 

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        

            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<City>()
                        .Property(c => c.Id)
                        .HasColumnName("Id");
            modelBuilder.Entity<City>()
                        .Property(c => c.Name)
                        .HasColumnName("Name");   
            modelBuilder.Entity<City>()                        
                        .HasOne(p => p.Sate);
                                                               
            modelBuilder.Entity<City>().HasKey(vf => new { vf.Id });

            modelBuilder.Entity<State>().ToTable("States");
            modelBuilder.Entity<State>()
                        .Property(c => c.Id)
                        .HasColumnName("Id");
            modelBuilder.Entity<State>()
                        .Property(c => c.Name)
                        .HasColumnName("Name");                   
            modelBuilder.Entity<State>().HasKey(vf => new { vf.Id });

            modelBuilder.Entity<Person>().ToTable("Persons");
            modelBuilder.Entity<Person>()
                        .Property(c => c.Id)
                        .HasColumnName("Id");
            modelBuilder.Entity<Person>()
                        .Property(c => c.Cedula)
                        .HasColumnName("Cedula");                   
            modelBuilder.Entity<Person>()
                        .Property(c => c.Name)
                        .HasColumnName("Name"); 
            modelBuilder.Entity<Person>()
                        .Property(c => c.Apellido)
                        .HasColumnName("Apellido"); 
            modelBuilder.Entity<Person>()
                        .Property(c => c.Edad)
                        .HasColumnName("Edad"); 
            modelBuilder.Entity<Person>()
                        .Property(c => c.Genero)
                        .HasColumnName("Genero"); 
            modelBuilder.Entity<Person>().HasKey(vf => new { vf.Id });
        }
      
    }
}