using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace SerialIzation_Deserializations
{
    public class Shedules
    {
        public void SerialIzationBinaryWithString()
        {
            string name = "sanjay singh";
            
            FileStream fileStream = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SerialIzation_Deserializations\stringmyfile1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, name);
            fileStream.Close();

        }
        public void DeSerializationBinaryWithString()
        {
            FileStream fs = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SerialIzation_Deserializations\stringmyfile1.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            string name=(string)binaryFormatter.Deserialize(fs);
            Console.WriteLine(name);    
        }
        public void SerialIzationBinaryWithObject()
        {
            Student student = new Student();
            student.id = 1001;
            student.name = "sanjay singh";
            student.age = 21;
            student.marks = 420;
            FileStream fileStream = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SerialIzation_Deserializations\objectmyfile1.txt", FileMode.Create);
            BinaryFormatter binFormatter = new BinaryFormatter();   
            binFormatter.Serialize(fileStream, student);
            fileStream.Close();

        }
        public void DeSerializationBinaryWithObject()
        {
            FileStream fileStream = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SerialIzation_Deserializations\objectmyfile1.txt", FileMode.Open);
            BinaryFormatter binaryFormatter= new BinaryFormatter();
            Student stu=(Student)binaryFormatter.Deserialize(fileStream);
            Console.WriteLine(stu.id);
            Console.WriteLine(stu.name);    
                
            Console.WriteLine(stu.age);
            Console.WriteLine(stu.marks);
            fileStream.Close();




        }
        public void ListOfSerialIzationBinaryWithObject()
        {
            List<Student> students = new List<Student>();
            Student student1=new Student();
            student1.id = 1002;
            student1.name = "Rahul Singh";
            student1.age = 21; ;
            student1.marks = 434;
            students.Add(student1);
            Student student2=new Student();
            student2.id = 1003;
            student2.name = "Rakesh Singh";
            student2.age = 22;
            student2.marks = 469;
            students.Add(student2);

            FileStream fileStream = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SerialIzation_Deserializations\listmyfile1.txt", FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, students);
            fileStream.Close();
        }

        public void ListOfDeSerialIzationBinaryWithObject()
        {

            FileStream fileStream = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SerialIzation_Deserializations\listmyfile1.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<Student> stu = (List<Student>)binaryFormatter.Deserialize(fileStream);
            foreach (Student student in stu)
            {
                Console.WriteLine(student.id);
                Console.WriteLine(student.name);
                Console.WriteLine(student.age);
                Console.WriteLine(student.marks);
            }
            fileStream.Close();
        }
        public void UsingXmlSerialiZation()
        {
            Student student1 = new Student();
            student1.id = 1001;
            student1.name = "sanjay singh RajPut ";
            student1.age = 61;
            student1.marks = 455;
            FileStream fileStream = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SerialIzation_Deserializations\xmlmyfile1.txt", FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            xmlSerializer.Serialize(fileStream, student1);
            fileStream.Close();    


        }
        public void UsingXmlDeSerialiZation()
        {
            FileStream fileStream = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\SerialIzation_Deserializations\xmlmyfile1.txt", FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            Student stu=(Student)xmlSerializer.Deserialize(fileStream);
            Console.WriteLine(stu.id);
            Console.WriteLine(stu.name);
            Console.WriteLine(stu.age);
            Console.WriteLine(stu.marks);

        }



    }
}
