﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV
{
    class ConnectString
    {
        public static string GetConnectionString()
        {
            return @"Data Source=DESKTOP;Initial Catalog=QLDSV;Integrated Security=True";
        }
    }
}
