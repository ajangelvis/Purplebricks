using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purplebricks
{
    class NewEmployees
    {
        

        public static void GetEmployeeMonthlySalaries()
        {
            List<Employees> employee = new List<Employees>();
           

            List<int> james_salary = new List<int> { 1500,1700,3000};

            List<int> shawn_salary = new List<int> { 2100, 2200, 4000 };

            List<int> adrian_salary = new List<int> { 4500, 1100, 1400 };

            employee.Add(new Employees("ID001","James",james_salary));

            employee.Add(new Employees("ID002", "shawn", shawn_salary));

            employee.Add(new Employees("ID003", "adrian", adrian_salary));

            List<List<int>> allsalary = new List<List<int>> { james_salary, shawn_salary, adrian_salary };

            
            var jamessalary = from total in james_salary where total > 0 select total;
            
            var shawnsalary = from total in shawn_salary where total > 0 select total;

            var adriansalary = from total in adrian_salary where total > 0 select total;

            var querry = allsalary.Select(i => i.ToArray());


            foreach (var amt in querry )
            {
                Console.WriteLine(amt);
                Console.WriteLine();

            }


            /*
            foreach (var amt in jamessalary )
            {
                Console.WriteLine(amt);
                Console.WriteLine( );

            }

            foreach (var amt in shawnsalary)
            {
                Console.WriteLine(amt);
            }

            foreach (var amt in adriansalary)
            {
                Console.WriteLine(amt);
            }
            */

            Console.ReadLine();

        }


       
    }
}
