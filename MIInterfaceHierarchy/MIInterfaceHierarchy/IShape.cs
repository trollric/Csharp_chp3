﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}
