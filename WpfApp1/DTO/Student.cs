using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Tools;

namespace WpfApp1.DTO
{
    [Table("student")]
    public class Student : BaseDTO
    {
        [Column("Group")]
        public int Group { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Second name")]
        public string Secondname { get; set; }

        [Column("Patronymic")]
        public string Patronymic { get; set; }
        
       
    }
}
