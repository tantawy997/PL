﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Email
    {
        public int id { get; set; }

        public string title { get; set; }

        public string body { get; set; }

        public string to { get; set; }

    }
}
