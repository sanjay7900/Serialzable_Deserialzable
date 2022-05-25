using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialIzation_Deserializations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shedules shedules = new Shedules();
            shedules.SerialIzationBinaryWithString();
            shedules.DeSerializationBinaryWithString();
            //----------------------------------
            shedules.SerialIzationBinaryWithObject();
            shedules.DeSerializationBinaryWithObject();
            shedules.ListOfSerialIzationBinaryWithObject();
            shedules.ListOfDeSerialIzationBinaryWithObject();
            shedules.UsingXmlSerialiZation();
            shedules.UsingXmlDeSerialiZation();
            Console.ReadKey();  
        }
    }
}
