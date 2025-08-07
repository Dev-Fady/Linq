using EF_Relationships.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Relationships
{
    public class Example
    {
        private readonly AppDbContext _context;
        public Example(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateUserWithProfile()
        {
            var user = new User
            {
                Name = "أحمد محمد",
                Email = "ahmed@Gmail.com"
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync(); // حفظ User أولاً للحصول على Id
            var profile = new UserProfile
            {
                UserId = user.Id, // استخدام الـ Id المُولد
                Bio = "مطور برمجيات",
                DateOfBirth = new DateTime(2011, 1, 1),
                proFilePicture = "profile.jpg"
            };
            _context.UserProfiles.Add(profile);
            await _context.SaveChangesAsync();
        }
        // =============================
        // إنشاء علاقة 1:M
        // =============================
        public async Task CreateCategoryWithProducts()
        {
            var category = new Category
            {
                Name = "إلكترونيات",
                Description = "أجهزة إلكترونية متنوعة"
            };

            var products = new List<Product>
        {
            new Product { Name = "لابتوب", Price = 15000, Category = category },
            new Product { Name = "موبايل", Price = 8000, Category = category },
            new Product { Name = "تابلت", Price = 17777, Category = category }
        };

            _context.Categories.Add(category);
            _context.Products.AddRange(products);
            await _context.SaveChangesAsync();
        }

        // =============================
        // إنشاء علاقة M:N (الطريقة الحديثة)
        // =============================
        public async Task EnrollStudentInCourses()
        {
            var student = new Student
            {
                Name = "Sara Ahmed",
                Email = "sara@example.com"
            };

            var courses = new List<Course>
        {
            new Course { Title = "البرمجة بـ C#", Credits = 3 },
            new Course { Title = "قواعد البيانات", Credits = 4 },
            new Course { Title = "تطوير الويب", Credits = 3 }
        };

            student.Courses = courses;

            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        // =============================
        // إنشاء علاقة M:N مع Junction Table
        // =============================
        public async Task EnrollStudentWithDetails()
        {
            var enrollments = new List<StudentCourse>
        {
            new StudentCourse
            {
                StudentId = 6,
                CourseId = 1,
                EnrollmentDate = DateTime.Now,
                Status = "Active"
            },
            new StudentCourse
            {
                StudentId = 6,
                CourseId = 2,
                EnrollmentDate = DateTime.Now,
                Status = "Active"
            }
        };

            _context.StudentCourses.AddRange(enrollments);
            await _context.SaveChangesAsync();
        }
    }
}
