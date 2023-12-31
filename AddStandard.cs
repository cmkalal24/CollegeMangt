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
    public class AddStandard
    {
        public string StandardTask()

        {
            Console.WriteLine("Select Standard Name");
            string StandardName = Console.ReadLine();
            Console.WriteLine("Select Standard HeadTeacher");
            string StandardHeadTeacher = Console.ReadLine();
            Console.WriteLine("Select Standard ClassName");
            string StandardClassName = Console.ReadLine();

            StandardTable SD = new StandardTable();
            SD.StandardName = StandardName;
            SD.StandardHeadTeacher = StandardHeadTeacher;
            SD.StandardClassName = StandardClassName;

            using (EF_CollegeMangtEntities EF = new EF_CollegeMangtEntities())
            {
                EF.Entry(SD).State = EntityState.Added;
                EF.SaveChanges();
            }
            Console.WriteLine("Standard Name="+ SD.StandardName);

            return "Data Save Successfully";
        }

        public void StandardInfo()
        {
            using (EF_CollegeMangtEntities EF = new EF_CollegeMangtEntities ())
            {
                var data = EF.SP_StandardTable().ToList();
                foreach (var row in data)
                {
                    Console.WriteLine(row.StandardName + "\t" + row.StandardHeadTeacher + "\t" + row.StandardClassName);
                }
            }
            
        }
    }
}
