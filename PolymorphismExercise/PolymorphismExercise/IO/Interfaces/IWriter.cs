﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PolymorphismExercise.IO.Interfaces
{
    public interface IWriter
    {
        void WriteLine(string str);
    }
}
