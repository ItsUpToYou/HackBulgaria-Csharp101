﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public abstract class Person
    {
        public string Gender { get; set; }

        public abstract string Doing();
    }
}
