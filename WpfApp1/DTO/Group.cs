using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Tools;

namespace WpfApp1.DTO
{
    [Table("group")]
    public class Group : BaseDTO
    {


        [Column("Speciality")]
        public string Speciality { get; set; }

        [Column("Curator")]
        public string Curator { get; set; }
    }
}
