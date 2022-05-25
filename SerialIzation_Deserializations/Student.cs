using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace SerialIzation_Deserializations
{
    [Serializable]
    public class Student
    {
        public int id { get; set; } 
        public string name { get; set; }
        public int age { get; set; }
        public int marks { get; set; }  

    }
}
