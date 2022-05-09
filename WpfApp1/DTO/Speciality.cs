using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Tools;

namespace WpfApp1.DTO
{
    [Table("speciality")]
    public class Speciality : BaseDTO
    {
        [Column("Name")]
        public string Name { get; set; }
    }
}
