using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorgovoPosredFirma.Model.Classes
{
    public class Module
    {
        public long Id { get; set; }
        public int IdParent { get; set; }
        public string MenuItemName { get; set; }
        public string? DllName { get; set; }
        public string? FunctionName { get; set; }
        public int SequenceNumber { get; set; }
    }
}
