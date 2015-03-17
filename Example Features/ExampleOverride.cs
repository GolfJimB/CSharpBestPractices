using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices
{
    class ExampleOverrideBase
    {
        protected virtual void SaveChanges()
        {}
    }

    class Derived : ExampleOverrideBase
    {
        protected override void SaveChanges()
        {
            Log("Before saving");
            base.SaveChanges();
            Log("After saving");
        }

        private void Log(string message)
        {
            //Logging code
        }
    }
}
