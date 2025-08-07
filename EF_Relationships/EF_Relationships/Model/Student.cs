using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ===============================================
// 3. علاقة Many-to-Many (M:N)
// ===============================================

namespace EF_Relationships.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
