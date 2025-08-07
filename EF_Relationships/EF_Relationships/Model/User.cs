using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// ===============================================
// 1. علاقة One-to-One (1:1)
// ===============================================

namespace EF_Relationships.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual UserProfile userProfile { get; set; }

    }
}
