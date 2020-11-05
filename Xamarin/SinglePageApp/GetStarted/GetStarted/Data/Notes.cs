using System;
using System.Collections.Generic;
using System.Text;

namespace GetStarted.Data
{
    public class Notes
    {
        public List<string> MyNote { get; set; }
        public Notes()
        {
            MyNote = new List<string>();
        }
    }
}
