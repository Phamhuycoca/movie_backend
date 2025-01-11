using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public class FillterQuery
    {
        public int page { get; set; } = 1;
        public int pageSize { get; set; } = 20;
        public dynamic? search { get; set; }
        public dynamic? filter { get; set; }
        public string? sorter { get; set; }
    }
}
