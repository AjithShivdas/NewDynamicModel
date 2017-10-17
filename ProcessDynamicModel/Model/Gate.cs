using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessDynamicModel.Model
{
    public class Gate
    {
        public int Id { get; set; }
        public bool IsOpen { get; set; }
        public string LeftGateName { get; set; }
        public string RightGateName { get; set; }
        public string GateName { get; set; }
        public string LeftOutlet { get; set; }
        public string RightOutlet { get; set; }

    }
}
