using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00DemoEntityFrameworkCurd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dacdbEntities obj = new dacdbEntities();
            #region Insert Using EF
            //obj.emps.Add(new emp()
            //{
            //    id = 8,
            //    name = "Adnan",
            //    emailId = "adnan@gmail.com"
            //});
            //obj.SaveChanges();
            #endregion

            #region Select Using EF
            //var allemps =obj.emps.ToList();
            //foreach (var emp in allemps)
            //{
            //    Console.WriteLine(emp.id +"|"+emp.name +"|"+emp.emailId);
            //}
            //Console.ReadLine();
            #endregion

            #region Update Using EF
            //var empToModifiedObj=(from emp in obj.emps.ToList()
            //                      where emp.id==8
            //                      select emp).First();
            //empToModifiedObj.name = "sami";
            //empToModifiedObj.emailId = "sami@gmial.com";
            //obj.SaveChanges();
            #endregion

            #region Delete using EF
            //var empToDeleted = (from emp in obj.emps.ToList()
            //                          where emp.id == 8
            //                          select emp).First();
            //obj.emps.Remove(empToDeleted);
            //obj.SaveChanges();
            #endregion

          



        }
    }
}
