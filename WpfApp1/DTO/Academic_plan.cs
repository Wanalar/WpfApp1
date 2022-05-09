using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Tools;

namespace WpfApp1.DTO
{
    internal class Academic_plan
    {
        [Column("Number of hours")]
        public int Number_of_hours { get; set; }
        [Column("Discipline")]
        public string Discipline { get; set; }
        [Column("Speciality")]
        public string Speciality { get; set; }
    }
}
