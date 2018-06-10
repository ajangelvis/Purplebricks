using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purplebricks
{
    class Employees
    {
        public  String ID { get; set; }

        public String Name { get; set; }

        public List<int> _Salary { get; set; }

        public Employees(String id, String name, List<int> salary)
        {
            this.ID = id;
            this.Name = name;
            this._Salary = salary;
        }


        public static int SumEmployeeSalary(List<int> emplsalary)
        {
            int sum = 0;

            foreach (int salary in emplsalary)
            {
                sum = sum + salary;
            }

            return sum;
        }


        public static int TotalSumEmployeeSalary(List<List<int>> emplsalary, int index)
        {
            int totalsum = 0;

            foreach (List<int> salary in emplsalary)
            {
                totalsum = totalsum + salary[index];
            }

            return totalsum;
        }




    }
}
