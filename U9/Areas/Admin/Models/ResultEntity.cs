using System.Collections.Generic;
using System.Linq;

namespace U9.Areas.Admin.Models
{
    public class ResultEntity<T>
    {
        public int Code { get; set; }

        public string Msg { get; set; }

        public int Count { get; set; }

        public List<T> Data { get; set; }
    }

}