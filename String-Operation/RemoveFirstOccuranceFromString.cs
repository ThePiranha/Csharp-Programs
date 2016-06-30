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
