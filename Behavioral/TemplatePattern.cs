using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Behavioral
{
    // The base class defines the overall algorithm/sequence,
    // and subclasses override specific steps when they need different behavior for their particular requirement. 
    internal class TemplatePattern
    {
        abstract class ReportGenerator
        {
            public void Generate()
            {
                FetchData();
                FormatData();
                Save();
            }

            protected abstract void FetchData();
            protected abstract void FormatData();

            protected virtual void Save()
                => Console.WriteLine("Saving report...");
        }
    }
}
