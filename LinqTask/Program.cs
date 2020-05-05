using System;
using System.Linq;
using System.Collections.Generic;
using VisioForge.Shared.MediaFoundation.OPM;
using System.Data;

// Employee details 
public class Employee
{

    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string JoiningDate { get; set; }
    public int Salary { get; set; }
    public string Department { get; set; }

}
public class Incentives
{
    public int EmployeeRefId { get; set; }
    public string IncentiveDate { get; set; }
    public int Incentive { get; set; }
}

class Program
{

    // Main method 
    static public void Main()
    {
        List<Employee> emp = new List<Employee>() {
                new Employee() { EmployeeId=1,FirstName="John",LastName="Abraham",Salary=1000000,JoiningDate="01-JAN-13 12:00:00 AM",Department="Banking" },

                new Employee() { EmployeeId= 2 , FirstName ="Michael" ,LastName ="Clarke", Salary =800000  ,JoiningDate = "01-JAN-13 12:00:00 AM",Department="Insurance"},

                new Employee() {  EmployeeId= 3 , FirstName ="Roy" ,LastName ="Thomas", Salary = 700000 ,JoiningDate = "01-FEB-13 12:00:00 AM",Department="Banking" },

                new Employee() {  EmployeeId= 4 , FirstName ="Tom" ,LastName ="Jose", Salary =600000  ,JoiningDate = "01-FEB-13 12:00:00 AM",Department="Insurance" },


                new Employee() {  EmployeeId= 5 , FirstName ="Jerry" ,LastName ="Pinto", Salary = 650000 ,JoiningDate = "01-FEB-13 12:00:00 AM",Department="Insurance" },

                new Employee() {  EmployeeId= 6 , FirstName ="Philip" ,LastName ="Mathew", Salary =750000  ,JoiningDate = "01-JAN-13 12:00:00 AM",Department="Services" },

                new Employee() {  EmployeeId= 7 , FirstName ="Suraj" ,LastName ="Bhargav", Salary = 650000 ,JoiningDate = "01-JAN-13 12:00:00 AM",Department="IT" },

                  new Employee() {  EmployeeId= 8 , FirstName ="Mayank" ,LastName ="Sharma", Salary =600000  ,JoiningDate = "01-FEB-13 12:00:00 AM",Department="Consulting" },

        };


        List<Incentives> inc = new List<Incentives>()
        {
        new Incentives(){ EmployeeRefId= 1 ,IncentiveDate="01-FEB-13",Incentive=5000 },
        new Incentives(){ EmployeeRefId= 2 ,IncentiveDate="01-FEB-13",Incentive=3000 },
        new Incentives(){ EmployeeRefId= 3 ,IncentiveDate="01-FEB-13",Incentive=4000 },
        new Incentives(){ EmployeeRefId= 1 ,IncentiveDate="01-JAN-13",Incentive=4500 },
        new Incentives(){ EmployeeRefId= 2 ,IncentiveDate="01-JAN-13",Incentive=3500 }
        };




        //2.Get all employee details from the employee table
         var res = from e in emp
                 where e.EmployeeId
          <= 211
            select e;


        //var res = Employee.All(e => e.EmployeeId > 212);
        foreach (var val in res)
        {
            Console.WriteLine("{0}  {1}  {2}  {3}",val.FirstName,val.LastName, val.Salary,val.Department);
        }

        Console.WriteLine("\n\n");


        //3.Get First_Name, Last_Name from employee table

        foreach (var val in res)
        {
            Console.WriteLine("{0}  {1}", val.FirstName, val.LastName);
        }

        //4.Get First_Name from employee table using alias name “Employee Name”

        foreach (var val in res)
        {
            Console.WriteLine("Name  -  {0}", val.FirstName);
        }



        //5.Get First_Name from employee table in upper case


        Console.WriteLine("\n\n");
        foreach (var val in res)
        {
            Console.WriteLine(val.FirstName.ToUpper());
        }


        // 6.Get First_Name from employee table in lower case


        Console.WriteLine("\n\n");
        foreach (var val in res)
        {
            Console.WriteLine(val.FirstName.ToLower());
        }


        //   7.Get unique DEPARTMENT from employee table


        //8.Select first 3 characters of FIRST_NAME from EMPLOYEE.

        foreach (var val in res)
        {
            string[] split = val.FirstName.Split(new char[] {  });
            //Console.WriteLine(split[0]);
            //Console.WriteLine(split[1]);
            //Console.WriteLine(split[2]);
        }

        // 9.Get position of 'o' in name 'John' from employee table
        Console.WriteLine("\n\n");
        var pro = from e in emp
                  where e.EmployeeId
           <= 200
                  select e;

        foreach (var val in pro){

            Console.WriteLine(val.FirstName.IndexOf("o")) ;
                
        }


        // 10.Get FIRST_NAME from employee table after removing white spaces from right side

        Console.WriteLine("\n\n");
        foreach (var val in res)
        {

            Console.WriteLine(val.FirstName.Trim());

        }




        // 11.Get FIRST_NAME from employee table after removing white spaces from left side
        Console.WriteLine("\n\n");
        foreach (var val in res)
        {

            Console.WriteLine(val.FirstName.Trim());

        }




        // 12.Get length of FIRST_NAME from employee table
        Console.WriteLine("\n\n");
        foreach (var val in res)
        {

            Console.WriteLine(val.FirstName.Length);

        }


        // 13.Get First_Name from employee table after replacing 'o' with '$'
        Console.WriteLine("\n\n");
        foreach (var val in res)
        {

            Console.WriteLine(val.FirstName.Length);

        }



        //14.Get First_Name and Last_Name as single column from employee table separated by a '_'
        Console.WriteLine("\n\n");
        foreach (var val in res)
        {

            Console.WriteLine("{0}_{1}",val.FirstName ,val.LastName);

        }



        //15.Get FIRST_NAME ,Joining year, Joining Month and Joining Date from employee table
        //16.Get all employee details from the employee table order by First_Name Ascending
        // 17.Get FIRST_NAME ,Joining year, Joining Month and Joining Date from employee table
        //  18.Get all employee details from the employee table order by First_Name Ascending
        //19.Get all employee details from the employee table order by First_Name Ascending and Salary descending
       


            //20.Get employee details from employee table whose employee name is “John”

            Console.WriteLine("\n\n");

        var john = emp.Where(e => e.FirstName == "John").FirstOrDefault();
        
        Console.WriteLine("{0} {1}  {2}  {3} {4}", john.FirstName ,john.LastName,john.Salary ,john.Department ,john.JoiningDate);




        //21.Get employee details from employee table whose employee name are “John” and “Roy”
      


        //var val = emp.All(e => e.FirstName == "John" || e => e.FirstName == "Roy").FirstOrDefault();

        //Console.WriteLine("{0} {1}  {2}  {3} {4}", john.FirstName, john.LastName, john.Salary, john.Department, john.JoiningDate);





        //22.Get employee details from employee table whose employee name are not “John” and “Roy”

        //var va = emp.All(e => e.FirstName).FirstOrDefault();





        //23.Get employee details from employee table whose first name starts with 'J'
        Console.WriteLine("\n\n");
        foreach (var val in res)
        {
            if (val.FirstName.IndexOf("j") == 0)
            {
                Console.WriteLine("{0} {1}    {2}    {3}", val.FirstName, val.LastName, val.Department, val.JoiningDate);
            }
        }


        //24.Get employee details from employee table whose first name contains 'o'
       
        foreach (var val in res)
        {
            if (val.FirstName.Contains("o") == true)
            {
                Console.WriteLine("{0} {1}    {2}    {3}", val.FirstName, val.LastName, val.Department, val.JoiningDate);
               }
        }




        //25.Get employee details from employee table whose first name ends with 'n'
        Console.WriteLine("\n\n");
        foreach (var val in res)
        {
            if (val.FirstName.EndsWith("n")==true)
            {
                Console.WriteLine("{0} {1}    {2}    {3}", val.FirstName, val.LastName, val.Department, val.JoiningDate);
            }
        }



        //   26.Get employee details from employee table whose first name ends with 'n' and name contains 4 letters
        Console.WriteLine("\n\n");
        foreach (var val in res)
        {
            if (val.FirstName.EndsWith("n") == true  && val.FirstName.Length==4)
            {
                Console.WriteLine("{0} {1}    {2}    {3}", val.FirstName, val.LastName, val.Department, val.JoiningDate);
            }
        }



        //28.Get employee details from employee table whose Salary greater than 600000
        Console.WriteLine("\n\n");
        foreach (var val in res)
        {
            if (val.Salary>600000)
            {
                Console.WriteLine("{0} {1}    {2}    {3}", val.FirstName, val.LastName, val.Department, val.Salary);
            }
        }


        //29.Get employee details from employee table whose Salary less than 800000

        Console.WriteLine("\n\n");
        foreach (var val in res)
        {
            if (val.Salary < 800000)
            {
                Console.WriteLine("{0} {1}    {2}    {3}", val.FirstName, val.LastName, val.Department, val.Salary);
            }
        }



        //30.Get employee details from employee table whose Salary between 500000 and 800000

        Console.WriteLine("\n\n");
        foreach (var val in res)
        {
            if (val.Salary >500000 && val.Salary <800000)
            {
                Console.WriteLine("{0} {1}    {2}    {3}", val.FirstName, val.LastName, val.Department, val.Salary);
            }
        }

        //  31.Get employee details from employee table whose name is 'John' and 'Michael'
        Console.WriteLine("\n\n");

//        var jo = emp.Where(e => e.FirstName == "John" ||e =>e.FirstName == "Michael");

        //Console.WriteLine("{0} {1}  {2}  {3} {4}", jo.FirstName, jo.LastName, jo.Salary, jo.Department, jo.JoiningDate);




    }


}