using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;

namespace challenge
{
    public class PythonOp
    {
       using (PyModule scope = Py.CreateScope())

        public PythonOp() { 

        }
        public void Initialize() {

            try {
                PythonEngine.Initialize();
                PythonEngine.BeginAllowThreads()
                scope = Py.CreateScope();
            } 
            catch { 
      

            }
        }
        public void Execute()
        {
            using (Py.GIL())
            {
                scope.Exec();
            }
        }
    }
}
