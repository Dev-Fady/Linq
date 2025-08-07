using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ===============================================
// 1. علاقة One-to-One (1:1)
// ===============================================


namespace EF_Relationships.Model
{
    public class UserProfile
    {
        [Key]
        [ForeignKey("user")]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        public string? Bio { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? proFilePicture { get; set; }

        public virtual User user { get; set; }
    }
}
