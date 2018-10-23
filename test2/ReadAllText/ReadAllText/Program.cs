using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAllText
{
    class Program
    {
        static void Main(string[] args)
        {
            EWordDocument eWordDocument = new EWordDocument();
            eWordDocument.Open(@"D:\教学\2018-2019\农业研究生C#\CSharp\test2\科研细则.docx");
            Console.WriteLine(eWordDocument.Text);
        }
    }
}
