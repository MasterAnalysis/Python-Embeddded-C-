using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace python
{
    class Program
    {
        static void Main(string[] args)
        {
            PythonOp pop = new PythonOp();
            pop.Initialize();
            pop.Execute();
        }
    }
}
