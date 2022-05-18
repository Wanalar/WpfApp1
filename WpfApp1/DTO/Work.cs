using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Tools;

namespace WpfApp1.DTO
{
    [Table("work")]
    public class Work : BaseDTO
    {
        [Column("Student")]
        public int Student { get; set; }

        [Column("Discipline")]
        public int Discipline { get; set; }

        [Column("Grade")]
        public int Grade { get; set; }

        [Column("Diploma and/or Coursework")]
        public string Diploma_or_Cursework { get; set; } 
        
    }
}
