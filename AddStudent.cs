using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CollegeManagt_InConsole.SchoolManagtDbContext;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace EF_CollegeManagt_InConsole
{
    public class AddStudent
    {
        public string PostStudent()

        {
            Console.WriteLine("Select Student Name");
            string StudentName = Console.ReadLine();
            Console.WriteLine("Select Student Email");
            string StudentEmail = Console.ReadLine();
            Console.WriteLine("Select Student Contact");
            string StudentContact = Console.ReadLine();
            Console.WriteLine("Select Student Address");
            string StudentAddress = Console.ReadLine();
            Console.WriteLine("Select Student ClassNo");
            string StudentClassNo = Console.ReadLine();
            Console.WriteLine("Select Student Division");
            string StudentDivision = Console.ReadLine();
            Console.WriteLine("Select Student RollNo");
            string StudentRollNo = Console.ReadLine();
            Console.WriteLine("Select Student Marks");
            string StudentMarks = Console.ReadLine();

            StudentTable ST = new StudentTable();
            ST.StudentName = StudentName;
            ST.StudentEmail = StudentEmail;
            ST.StudentContact = StudentContact;
            ST.StudentAddress = StudentAddress;
            ST.StudentClassNo = StudentClassNo;
            ST.StudentDivision = StudentDivision;
            ST.StudentRollNo = StudentRollNo;
            ST.StudentMarks = StudentMarks;

            using (EF_CollegeMangtEntities EF = new EF_CollegeMangtEntities())
            {
                EF.Entry(ST).State = EntityState.Added;
                EF.SaveChanges();
            }

            Console.WriteLine("Student Name=" + ST.StudentName);

            return "Data Save Successfully";
        }

        public void StudentReport()
        {
            using (EF_CollegeMangtEntities EF = new EF_CollegeMangtEntities())
            {
                var data = EF.SP_StudentTable().ToList();
                foreach (var row in data)
                {
                    Console.WriteLine(row.StudentName + "\t" + row.StudentEmail + "\t" + row.StudentContact + "\t" + row.StudentAddress + "\t"
                        + row.StudentClassNo + "\t" + row.StudentDivision + "\t" + row.StudentRollNo + "\t" + row.StudentMarks);
                }


            }
            
        }


            
        }
    
}
