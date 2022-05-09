using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Tools;

namespace WpfApp1.DTO
{
    [Table("discipline")]
    public class Discipline : BaseDTO
    {
        [Column("Title")]
        public string Title { get; set; } 


    }
}
