using System;
using System.Collections.Generic;
using InheritanceDiner.Models;

namespace InheritanceDiner
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Supervisor Porter = new Supervisor("Porter", "k24lk32");
      Manager Mark = new Manager("Mark", "23kh4kj32", 1111);

      List<Employee> Employees = new List<Employee>() {
          Porter,
          Mark
      };
      Employees.ForEach(e =>
      {
        System.Console.Write(e.Name + ": ");
        e.Discount();
        if (e is Manager)
        {
          Manager m = (Manager)e;
          m.Delegate();
        }
      });
    }
  }
}
