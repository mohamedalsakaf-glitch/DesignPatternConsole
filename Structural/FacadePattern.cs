using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Structural
{
    // Facade Pattern provides a simplified interface to a complex subsystem.
    internal class FacadePattern
    {
        class WordReader
        {
            public void Read(string file) => Console.WriteLine("Reading Word");
        }

        class PdfConverter
        {
            public void Convert() => Console.WriteLine("Converting to PDF");
        }

        class PdfWriter
        {
            public void Save() => Console.WriteLine("Saving PDF");
        }

        // Facade
        public class WordToPdfFacade
        {
            private readonly WordReader _reader = new();
            private readonly PdfConverter _converter = new();
            private readonly PdfWriter _writer = new();

            public void Convert(string wordFile)
            {
                _reader.Read(wordFile);
                _converter.Convert();
                _writer.Save();
            }
        }

        
    }
}
