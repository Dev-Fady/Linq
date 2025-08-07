using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ===============================================
// 2. علاقة One-to-Many (1:M)
// ===============================================
namespace EF_Relationships.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public virtual List<Product> Products { get; set; } = new List<Product>();

    }
}
