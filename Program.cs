using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CollegeManagt_InConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Subject");
            Console.WriteLine("3.Add Standard");
            Console.WriteLine("4.Student Report");
            Console.WriteLine("5.Subject Info");
            Console.WriteLine("6.Standard Info");
            Console.WriteLine("Select from above option");
            int option =Convert.ToInt32(Console.ReadLine());

            switch (option)

            {
                case 1:

                AddStudent Student=new AddStudent();
                string output = Student.PostStudent();
                Console.WriteLine(output);
                Console.ReadLine();
                break;

                case 2:

                 AddSubject Subject =new AddSubject();
                 string output1 = Subject.SubjectTask();
                 Console.WriteLine(output1);
                 Console.ReadLine();
                 break;

                case 3:

                AddStandard Standard =new AddStandard();
                string output2 = Standard.StandardTask();
                Console.WriteLine(output2);
                Console.ReadLine();
                break;

                case 4:

                AddStudent Student1 =new AddStudent();
                Student1.StudentReport();
                Console.ReadLine() ;
                return;

                case 5:

                AddSubject Subject1 =new AddSubject();
                Subject1.SubjectInfo();
                Console.ReadLine();
                return;

                case 6:

                AddStandard Standard1 =new AddStandard();
                Standard1.StandardInfo();
                Console.ReadLine();
                return;

                case 7:

                Console.WriteLine("Insert Invalid option please check and Try again!");
                Console.ReadLine();
                return;

            }

        }
    }
}
