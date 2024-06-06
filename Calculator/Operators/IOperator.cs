﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public interface IOperator
    {
        float run(float a, float b);
        string ToString();
    }
}
