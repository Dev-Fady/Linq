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
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
