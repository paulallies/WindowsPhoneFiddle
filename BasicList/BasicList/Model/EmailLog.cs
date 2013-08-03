using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicList.Model
{
    public class EmailLog
    {
        public DateTime DateSent { get; set; }
        public User SentBy { get; set; }
    }
}
