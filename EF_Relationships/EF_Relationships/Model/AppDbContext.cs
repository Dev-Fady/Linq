using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Relationships.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-JR16FNI;Initial Catalog=EF-Relationships;Integrated Security=True ; Trust Server Certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // =============================
            // One-to-One Configuration
            // =============================
            modelBuilder.Entity<User>()
                .HasOne(u => u.userProfile)
                .WithOne(p => p.user)
                .HasForeignKey<UserProfile>(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // =============================
            // One-to-Many Configuration
            // =============================
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict); // منع حذف Category لو فيها Products

            // =============================
            // Many-to-Many Configuration (الطريقة الحديثة)
            // =============================
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students);

            // =============================
            // إضافة Indexes للأداء
            // =============================
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.CategoryId)
                .HasDatabaseName("IX_Product_CategoryId");

            modelBuilder.Entity<UserProfile>()
                .HasIndex(up => up.UserId)
                .IsUnique(); // فريد للعلاقة 1:1


            // =============================
            // SEED DATA - إضافة بيانات أولية
            // =============================
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // =============================
            // Users Data
            // =============================
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "أحمد محمد", Email = "ahmed@example.com" },
                new User { Id = 2, Name = "فاطمة علي", Email = "fatima@example.com" },
                new User { Id = 3, Name = "محمد حسن", Email = "mohamed@example.com" },
                new User { Id = 4, Name = "سارة أحمد", Email = "sara@example.com" },
                new User { Id = 5, Name = "عمر خالد", Email = "omar@example.com" }
            );

            // =============================
            // UserProfiles Data
            // =============================
            modelBuilder.Entity<UserProfile>().HasData(
                new UserProfile
                {
                    UserId = 1,
                    Bio = "مطور برمجيات متخصص في .NET",
                    DateOfBirth = new DateTime(1990, 5, 15),
                    proFilePicture = "ahmed_profile.jpg"
                },
                new UserProfile
                {
                    UserId = 2,
                    Bio = "مصممة UI/UX مبدعة",
                    DateOfBirth = new DateTime(1992, 8, 22),
                    proFilePicture = "fatima_profile.jpg"
                },
                new UserProfile
                {
                    UserId = 3,
                    Bio = "محلل بيانات وخبير في Machine Learning",
                    DateOfBirth = new DateTime(1988, 12, 10),
                    proFilePicture = "mohamed_profile.jpg"
                },
                new UserProfile
                {
                    UserId = 4,
                    Bio = "مديرة مشاريع تقنية",
                    DateOfBirth = new DateTime(1991, 3, 7),
                    proFilePicture = "sara_profile.jpg"
                },
                new UserProfile
                {
                    UserId = 5,
                    Bio = "مهندس DevOps ومختص في Cloud Computing",
                    DateOfBirth = new DateTime(1989, 11, 30),
                    proFilePicture = "omar_profile.jpg"
                }
            );

            // =============================
            // Categories Data
            // =============================
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "إلكترونيات", Description = "أجهزة إلكترونية وتقنية متطورة" },
                new Category { Id = 2, Name = "كتب", Description = "كتب علمية وثقافية منوعة" },
                new Category { Id = 3, Name = "ملابس", Description = "ملابس عصرية للرجال والنساء" },
                new Category { Id = 4, Name = "رياضة", Description = "معدات وأدوات رياضية" },
                new Category { Id = 5, Name = "منزل وحديقة", Description = "أدوات منزلية ومعدات حديقة" }
            );

            // =============================
            // Products Data
            // =============================
            modelBuilder.Entity<Product>().HasData(
                // إلكترونيات
                new Product { Id = 1, Name = "لابتوب Dell XPS", Price = 25000, CategoryId = 1 },
                new Product { Id = 2, Name = "هاتف iPhone 15", Price = 18000, CategoryId = 1 },
                new Product { Id = 3, Name = "تابلت Samsung Galaxy", Price = 8000, CategoryId = 1 },
                new Product { Id = 4, Name = "سماعات Sony WH-1000XM4", Price = 3500, CategoryId = 1 },

                // كتب
                new Product { Id = 5, Name = "Clean Code", Price = 150, CategoryId = 2 },
                new Product { Id = 6, Name = "Design Patterns", Price = 200, CategoryId = 2 },
                new Product { Id = 7, Name = "The Pragmatic Programmer", Price = 180, CategoryId = 2 },

                // ملابس
                new Product { Id = 8, Name = "قميص قطني أزرق", Price = 120, CategoryId = 3 },
                new Product { Id = 9, Name = "جينز كلاسيكي", Price = 300, CategoryId = 3 },
                new Product { Id = 10, Name = "حذاء رياضي Nike", Price = 800, CategoryId = 3 },

                // رياضة
                new Product { Id = 11, Name = "دراجة هوائية", Price = 2500, CategoryId = 4 },
                new Product { Id = 12, Name = "أوزان حديد", Price = 500, CategoryId = 4 },

                // منزل وحديقة
                new Product { Id = 13, Name = "مكنسة كهربائية", Price = 1200, CategoryId = 5 },
                new Product { Id = 14, Name = "أدوات حديقة", Price = 350, CategoryId = 5 }
            );

            // =============================
            // Students Data
            // =============================
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "علي محمد", Email = "ali.mohamed@student.edu" },
                new Student { Id = 2, Name = "نور أحمد", Email = "nour.ahmed@student.edu" },
                new Student { Id = 3, Name = "حسام خالد", Email = "hosam.khaled@student.edu" },
                new Student { Id = 4, Name = "ريم سعد", Email = "reem.saad@student.edu" },
                new Student { Id = 5, Name = "يوسف عبدالله", Email = "youssef.abdullah@student.edu" }
            );

            // =============================
            // Courses Data
            // =============================
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Title = "البرمجة بـ C#", Credits = 3 },
                new Course { Id = 2, Title = "قواعد البيانات", Credits = 4 },
                new Course { Id = 3, Title = "تطوير الويب", Credits = 3 },
                new Course { Id = 4, Title = "هندسة البرمجيات", Credits = 4 },
                new Course { Id = 5, Title = "الذكاء الاصطناعي", Credits = 3 },
                new Course { Id = 6, Title = "أمن المعلومات", Credits = 3 },
                new Course { Id = 7, Title = "الشبكات والاتصالات", Credits = 4 }
            );

            // =============================
            // StudentCourses Data (Junction Table)
            // =============================
            modelBuilder.Entity<StudentCourse>().HasData(
                // علي محمد - 4 كورسات
                new StudentCourse
                {
                    StudentId = 1,
                    CourseId = 1,
                    EnrollmentDate = new DateTime(2024, 1, 15),
                    Grade = 85.5m,
                    Status = "Completed"
                },
                new StudentCourse
                {
                    StudentId = 1,
                    CourseId = 2,
                    EnrollmentDate = new DateTime(2024, 2, 1),
                    Grade = 92.0m,
                    Status = "Completed"
                },
                new StudentCourse
                {
                    StudentId = 1,
                    CourseId = 3,
                    EnrollmentDate = new DateTime(2024, 8, 1),
                    Grade = null,
                    Status = "Active"
                },
                new StudentCourse
                {
                    StudentId = 1,
                    CourseId = 4,
                    EnrollmentDate = new DateTime(2024, 8, 1),
                    Grade = null,
                    Status = "Active"
                },

                // نور أحمد - 3 كورسات
                new StudentCourse
                {
                    StudentId = 2,
                    CourseId = 1,
                    EnrollmentDate = new DateTime(2024, 1, 15),
                    Grade = 78.5m,
                    Status = "Completed"
                },
                new StudentCourse
                {
                    StudentId = 2,
                    CourseId = 5,
                    EnrollmentDate = new DateTime(2024, 2, 10),
                    Grade = 88.0m,
                    Status = "Completed"
                },
                new StudentCourse
                {
                    StudentId = 2,
                    CourseId = 6,
                    EnrollmentDate = new DateTime(2024, 8, 1),
                    Grade = null,
                    Status = "Active"
                },

                // حسام خالد - 3 كورسات
                new StudentCourse
                {
                    StudentId = 3,
                    CourseId = 2,
                    EnrollmentDate = new DateTime(2024, 1, 20),
                    Grade = 90.5m,
                    Status = "Completed"
                },
                new StudentCourse
                {
                    StudentId = 3,
                    CourseId = 3,
                    EnrollmentDate = new DateTime(2024, 2, 5),
                    Grade = 87.0m,
                    Status = "Completed"
                },
                new StudentCourse
                {
                    StudentId = 3,
                    CourseId = 7,
                    EnrollmentDate = new DateTime(2024, 8, 1),
                    Grade = null,
                    Status = "Active"
                },

                // ريم سعد - 2 كورسات
                new StudentCourse
                {
                    StudentId = 4,
                    CourseId = 4,
                    EnrollmentDate = new DateTime(2024, 1, 25),
                    Grade = 95.0m,
                    Status = "Completed"
                },
                new StudentCourse
                {
                    StudentId = 4,
                    CourseId = 5,
                    EnrollmentDate = new DateTime(2024, 8, 1),
                    Grade = null,
                    Status = "Active"
                },

                // يوسف عبدالله - 2 كورسات
                new StudentCourse
                {
                    StudentId = 5,
                    CourseId = 6,
                    EnrollmentDate = new DateTime(2024, 2, 15),
                    Grade = 82.5m,
                    Status = "Completed"
                },
                new StudentCourse
                {
                    StudentId = 5,
                    CourseId = 7,
                    EnrollmentDate = new DateTime(2024, 8, 1),
                    Grade = null,
                    Status = "Active"
                }
            );
        }

    }
}
