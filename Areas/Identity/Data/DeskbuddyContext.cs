using Deskbuddy.Areas.Identity.Data;
using Deskbuddy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Deskbuddy.Data;

public class DeskbuddyContext : IdentityDbContext<DeskbuddyUser>
{
    public DeskbuddyContext(DbContextOptions<DeskbuddyContext> options)
        : base(options)
    {
    }
    
    public DbSet<Department> Departments { get; set; }

    public DbSet<EmployeeId> Employees { get; set; }

    public DbSet<Workplace> Workplaces { get; set; }

    public DbSet<Room> Rooms { get; set; }

    public DbSet<Occupancy> Occupancies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        PasswordHasher<DeskbuddyUser> hasher = new PasswordHasher<DeskbuddyUser>();

        // Seed Users
        DeskbuddyUser adminUser = new DeskbuddyUser() { Id = Guid.NewGuid().ToString(), UserName = "admin@abc.com" };
        adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
        adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin*123");
        modelBuilder.Entity<DeskbuddyUser>().HasData(adminUser);

        DeskbuddyUser sekretariatUser = new DeskbuddyUser() { Id = Guid.NewGuid().ToString(), UserName = "sekretariat@abc.com" };
        sekretariatUser.NormalizedUserName = sekretariatUser.UserName.ToUpper();
        sekretariatUser.PasswordHash = hasher.HashPassword(sekretariatUser, "Sekretariat*123");
        modelBuilder.Entity<DeskbuddyUser>().HasData(sekretariatUser);

        DeskbuddyUser mitarbeiterUser = new DeskbuddyUser() { Id = Guid.NewGuid().ToString(), UserName = "mitarbeiter@abc.com" };
        mitarbeiterUser.NormalizedUserName = mitarbeiterUser.UserName.ToUpper();
        mitarbeiterUser.PasswordHash = hasher.HashPassword(mitarbeiterUser, "Mitarbeiter*123");
        modelBuilder.Entity<DeskbuddyUser>().HasData(mitarbeiterUser);

        DeskbuddyUser abteilungsleiterUser = new DeskbuddyUser() { Id = Guid.NewGuid().ToString(), UserName = "abteilungsleiter@abc.com" };
        abteilungsleiterUser.NormalizedUserName = abteilungsleiterUser.UserName.ToUpper();
        abteilungsleiterUser.PasswordHash = hasher.HashPassword(abteilungsleiterUser, "Abteilungsleiter*123");
        modelBuilder.Entity<DeskbuddyUser>().HasData(abteilungsleiterUser);

        // Seed Roles
        IdentityRole adminRole = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "Administrator" };
        adminRole.NormalizedName = adminRole.Name.ToUpper();
        modelBuilder.Entity<IdentityRole>().HasData(adminRole);

        IdentityRole sekretariatRole = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "Sekretariat" };
        sekretariatRole.NormalizedName = sekretariatRole.Name.ToUpper();
        modelBuilder.Entity<IdentityRole>().HasData(sekretariatRole);

        IdentityRole mitarbeiterRole = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "Mitarbeiter" };
        mitarbeiterRole.NormalizedName = mitarbeiterRole.Name.ToUpper();
        modelBuilder.Entity<IdentityRole>().HasData(mitarbeiterRole);

        IdentityRole abteilungsleiterRole = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "Abteilungsleiter" };
        abteilungsleiterRole.NormalizedName = abteilungsleiterRole.Name.ToUpper();
        modelBuilder.Entity<IdentityRole>().HasData(abteilungsleiterRole);

        // Assign Roles to Users
        IdentityUserRole<string> adminUserRole = new IdentityUserRole<string> { UserId = adminUser.Id, RoleId = adminRole.Id };
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(adminUserRole);

        IdentityUserRole<string> sekretariatUserRole = new IdentityUserRole<string> { UserId = sekretariatUser.Id, RoleId = sekretariatRole.Id };
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(sekretariatUserRole);

        IdentityUserRole<string> mitarbeiterUserRole = new IdentityUserRole<string> { UserId = mitarbeiterUser.Id, RoleId = mitarbeiterRole.Id };
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(mitarbeiterUserRole);

        IdentityUserRole<string> abteilungsleiterUserRole = new IdentityUserRole<string> { UserId = abteilungsleiterUser.Id, RoleId = abteilungsleiterRole.Id };
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(abteilungsleiterUserRole);

        // Seeding data for Departments
        modelBuilder.Entity<Department>().HasData(
            new Department { Id = 1, Name = "Finanzen", Chief = "Anton Meier" },
            new Department { Id = 2, Name = "Einkauf", Chief = "Bernd Schmidt" },
            new Department { Id = 3, Name = "Verkauf", Chief = "Clara Fischer" },
            new Department { Id = 4, Name = "HR", Chief = "Dieter Weber" },
            new Department { Id = 5, Name = "KundenSupport", Chief = "Eva Müller" }
        );

        // Seeding data for Employees
        string[] vorname = new string[] { "Anton", "Bernd", "Clara", "Dieter", "Eva", "Friedrich", "Greta", "Heinz", "Ingrid", "Johann" };
        string[] nachname = new string[] { "Meier", "Schmidt", "Fischer", "Weber", "Müller", "Bauer", "Richter", "Koch", "Wagner", "Becker" };
        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            string vn = vorname[rnd.Next(vorname.Length)];
            string nn = nachname[rnd.Next(nachname.Length)];
            int departmentId = rnd.Next(1, 6); // Assuming there are 5 departments
            string userId = Guid.NewGuid().ToString();
            string userName = vn.ToLower() + nn.ToLower() + "@abc.com";

            modelBuilder.Entity<EmployeeId>().HasData(new EmployeeId
            {
                Id = i + 1,
                Name = vn + " " + nn,
                DepartmentId = departmentId,
            });
        }
            //Seeding data for Room

            for (int i = 0; i < 200; i++)
        {
            string roomNumber = (i + 1).ToString("D3");
            modelBuilder.Entity<Room>().HasData(new Room
            {
                Id = i + 1,
                Name = "R" + roomNumber,
            });
        }

        //Seeding data for Workplaces
        string[] eq = new string[] { "Tische", "Beamer", "Schwarzlicht", "Bühne", "Stühle" };
        string[] sp = new string[] { " ", "Ruheraum", "Partyraum", "Schlafraum" };

        for (int i = 0; i < 200; i++)
        {
            string ds = eq[rnd.Next(eq.Length)];
            string spl = sp[rnd.Next(sp.Length)];
            int roomId = i + 1;

            modelBuilder.Entity<Workplace>().HasData(new Workplace
            {
                Id = i + 1,
                Description = ds,
                SpecialProperties = spl,
                RoomId = roomId
            });
        }

        //Seeding date for Occupancies

        // Define the start and end date range (current month to next month)
        DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Start of current month
        DateTime endDate = startDate.AddMonths(1); // Start of next month

        for (int i = 0; i < 200; i++)
        {
            // Generate a random number of days to add within the date range
            int daysToAdd = rnd.Next(0, (int)(endDate - startDate).TotalDays);

            DateTime randomDate = startDate.AddDays(daysToAdd);
            int roomId = i + 1;

            modelBuilder.Entity<Occupancy>().HasData(new Occupancy
            {
                Id = i + 1,
                RoomId = roomId,
                Date = randomDate,
                EmployeeId = null,
            });
        }

        // Konfigurationen für die einzelnen Entitäten, z.B. Indizes, Beziehungen usw.
        modelBuilder.Entity<Department>().ToTable("Departments");
        modelBuilder.Entity<EmployeeId>().ToTable("Employees");
        modelBuilder.Entity<Workplace>().ToTable("Workplaces");
        modelBuilder.Entity<Room>().ToTable("Rooms");
        modelBuilder.Entity<Occupancy>().ToTable("Occupancies");

        // Beziehungen zwischen den Entitäten definieren
        modelBuilder.Entity<EmployeeId>()
            .HasOne(e => e.Department)
            .WithMany(d => d.Employees)
            .HasForeignKey(e => e.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict); // Verhindert das Löschen von Abteilungen mit zugewiesenen Mitarbeitenden


        modelBuilder.Entity<Workplace>()
            .HasOne(w => w.Room)
            .WithMany()
            .HasForeignKey(w => w.RoomId)
            .OnDelete(DeleteBehavior.Restrict); // Verhindert das Löschen von Räumen mit zugewiesenen Arbeitsplätzen

        modelBuilder.Entity<Occupancy>()
        .HasOne(o => o.Employee)
        .WithMany(e => e.Occupancies)
        .HasForeignKey(o => o.EmployeeId);

        // Configure the Occupancy - Room relationship
        modelBuilder.Entity<Occupancy>()
            .HasOne(o => o.Room)
            .WithMany(w => w.Occupancies)
            .HasForeignKey(o => o.RoomId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Occupancy>()
            .HasOne(o => o.User)
            .WithMany(u => u.Occupancies)  // Adjust this relationship according to your needs
            .HasForeignKey(o => o.UserId);

        base.OnModelCreating(modelBuilder);
    }
}
