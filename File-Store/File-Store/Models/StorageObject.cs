using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Store.Models
{
    public class StorageObject
    {
        public int id { get; set; }   
        public string name { get; set; }
        public StorageType type { get; set; }
    }
}
