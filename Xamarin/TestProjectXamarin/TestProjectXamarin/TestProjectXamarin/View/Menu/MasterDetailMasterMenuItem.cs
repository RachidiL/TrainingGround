﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectXamarin.View.Menu
{

    public class MasterDetailMasterMenuItem
    {
        public MasterDetailMasterMenuItem()
        {
            TargetType = typeof(MasterDetailMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}