///----------------------------------------------------------------------------------------------------
/// This program removes the first dot (".") in a string.
/// 
/// Example:
/// Input: C:\Service\Cert\var\xml_spool\output\dump\0628\1715\.20101461786-01-F001-00000021.XML.0.xml
/// Output: C:\Service\Cert\var\xml_spool\output\dump\0628\1715\20101461786-01-F001-00000021.XML.0.xml
/// 
/// This can be done in various way some of the way is below.
/// ----------------------------------------------------------------------------------------------------

//Example: 01
using System;
using System.Text.RegularExpressions;

namespace FirstOccuranceStringRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            string main= ("C:\\AceptaService\\Peru_Cert\\var\\ca4xml_spool\\output\\dump\\0628\\1715\\.20101461786-01-F001-00000021.XML.0.xml");
            Regex regex = new Regex(Regex.Escape("."));
            string result = regex.Replace(main, "", 1);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

//Example: 02
using System;

namespace FirstOccuranceStringRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            string main = @"C:\AceptaService\Peru_Cert\var\ca4xml_spool\output\dump\0628\1715\.20101461786 - 01 - F001 - 00000021.XML.0.xml";
            string result = main.Remove(main.IndexOf('.'), 1);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

//Example: 03
using System;
using System.IO;

namespace FirstOccuranceStringRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            string main = @"C:\AceptaService\Peru_Cert\var\ca4xml_spool\output\dump\0628\1715\.20101461786 - 01 - F001 - 00000021.XML.0.xml";
            string filename = Path.GetFileName(main).TrimStart(new char[] { '.' });
            string result = Path.Combine(Path.GetDirectoryName(main), filename);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

//Example: 04
using System;
using System.Text;

namespace FirstOccuranceStringRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            bool foundFirst = false;
            StringBuilder temp = new StringBuilder();
            string main = @"C:\AceptaService\Peru_Cert\var\ca4xml_spool\output\dump\0628\1715\.20101461786 - 01 - F001 - 00000021.XML.0.xml";
            
            foreach (char Character in main)
            {
                if (!foundFirst && Character == '.')
                    foundFirst = true;
                else
                    temp.Append(Character);
            }

            string result = temp.ToString();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

//Example: 05
using System;

namespace FirstOccuranceStringRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            string main = @"C:\AceptaService\Peru_Cert\var\ca4xml_spool\output\dump\0628\1715\.20101461786 - 01 - F001 - 00000021.XML.0.xml";

            if (main[main.LastIndexOf('\\') + 1] == '.')
            {
                result = "Path has a dot";
            }
            else
            {
                result = "Path does not has a dot";
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
