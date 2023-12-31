using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CollegeManagt_InConsole.SchoolManagtDbContext;
using System.Data.Entity;
using Microsoft.Win32;

namespace EF_CollegeManagt_InConsole
{
    public class AddSubject
    {
        public string SubjectTask()

        {
            Console.WriteLine("Select Subject Name");
            string SubjectName = Console.ReadLine();
            Console.WriteLine("Select Subject Teacher");
            string SubjectTeacher = Console.ReadLine();
            Console.WriteLine("Select Subject Code");
            string SubjectCode = Console.ReadLine();

            SubjectTable SU = new SubjectTable();
            SU.SubjectName = SubjectName;
            SU.SubjectTeacher = SubjectTeacher;
            SU.SubjectCode = SubjectCode;

            using (EF_CollegeMangtEntities EF = new EF_CollegeMangtEntities())
            {
                EF.Entry(SU).State = EntityState.Added;
                EF.SaveChanges();
            }

            Console.WriteLine("Subject Name=" + SU.SubjectName);

            return "Save Data Successfully";
        }
           

        public void SubjectInfo()
        {
            using (EF_CollegeMangtEntities EF = new EF_CollegeMangtEntities())
            {
                var data = EF.SP_SubjectTable ().ToList();
                foreach (var row in data)
                {
                    Console.WriteLine(row.SubjectName +"\t" +row.SubjectTeacher +"\t" +row.SubjectTeacher +"\t" +row.SubjectCode);
                }
               
            }
        }
    }
}
