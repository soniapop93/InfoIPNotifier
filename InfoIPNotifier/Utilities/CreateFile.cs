using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoIPNotifier.Utilities
{
    public class CreateFile
    {
        public static void generateFile(string text, string path)
        {
            string fileName = String.Format("YourIP_Information_{0}", DateTime.Now.ToString("dd_MM_yyyy"));
            Console.WriteLine("Will generate new text file with name: {0}", fileName);

            
        }
    }
}
