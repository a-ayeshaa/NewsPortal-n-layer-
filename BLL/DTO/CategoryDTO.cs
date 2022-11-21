using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class CategoryDTO
    {
        [Required]
        public int id { get; set; }
        public string name { get; set; }


    }
}
