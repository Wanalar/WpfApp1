using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Tools;

namespace WpfApp1.DTO
{
    internal class Teacher
    {
        [Column("Name")]
        public string Name { get; set; }

        [Column("Second name")]
        public string Second_name { get; set; }

        [Column("Patronymic")]
        public string Patronymic { get; set; }
    }
}
