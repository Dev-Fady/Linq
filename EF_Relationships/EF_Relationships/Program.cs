using EF_Relationships.Model;

namespace EF_Relationships
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            AppDbContext appDb = new AppDbContext();
            Example example = new Example(appDb);
            //await example.CreateUserWithProfile();

            //await example.CreateCategoryWithProducts();
            //await example.EnrollStudentInCourses();
            await example.EnrollStudentWithDetails();
        }
    }
}
