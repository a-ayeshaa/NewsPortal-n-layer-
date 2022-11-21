using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class NewsDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public int category_id { get; set; }
        public System.DateTime date { get; set; }

        public virtual CategoryDTO CategoryDTO { get; set; }

    }
}
