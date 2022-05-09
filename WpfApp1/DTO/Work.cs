using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Tools;

namespace WpfApp1.DTO
{
    internal class Work
    {
        [Column("Student")]
        public string Student { get; set; }
        [Column("Discipline")]
        public string Discipline { get; set; }
        [Column("Grade")]
        public int Grade { get; set; }

        [Column("Diploma and/or Coursework")]
        public string Diploma_or_Coursework { get; set; } 
        
    }
}
