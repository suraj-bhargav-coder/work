using CompanyManagement.Models;
using System;
using System.Linq;

namespace CompanyManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            int choice;
            do
            {
                Console.WriteLine("Choose Option as \n\n 1. Admin \n 2. Manager\n 3. Exit ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        p.Admin();
                        break;

                    case 2:
                        p.Manager();
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 3);
        }





        public void Admin()
        {
            int choice;
            do
            {
                Console.WriteLine("Choose Which Operation do you want to perform!!\n");
                Console.WriteLine("1. Add Employee Details\n");
                Console.WriteLine("2. Delete Employee Details\n");
                Console.WriteLine("3. Add Business unit Detail\n");
                Console.WriteLine("4. Delete Business Unit Details\n");
                Console.WriteLine("5. Add Project Info\n");
                Console.WriteLine("6. Delete Project Info\n");
                Console.WriteLine("7. Assign Project to the employee\n");
                Console.WriteLine("8. View List of Business Units\n");
                Console.WriteLine("9. Exit");
                Console.WriteLine("Enter Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployeeDetails();
                        break;

                    case 2:
                        DeleteEmployeeDetails();
                        break;

                    case 3:
                        AddBusinessUnit();
                        break;

                    case 4:
                        DeleteBusinessUnit();
                        break;

                    case 5:
                        AddProjectInfo();
                        break;


                    case 6:
                        DeleteProjectInfo();
                        break;

                    case 7:
                        AssignProjects();
                        break;

                    case 8:
                        BusinessUnitList();
                        break;
                    case 9:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
            while (choice != 9);

        }

        public void Manager()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Employee list");
                Console.WriteLine("2. Check Project AssignMant to the Employee");
                Console.WriteLine("3. List of Employes On vacation");
                Console.WriteLine("4. Assign Vacation To the Employeevacation");
                Console.WriteLine("5.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EmployeeList();
                        break;

                    case 2:
                        ViewAssignedProjects();
                        break;

                    case 3:
                        EmployeeVacationList();
                        break;

                    case 4:
                        AssignVacation();
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice\n");
                        break;

                }
            }
            while (choice != 5);
        }


       
        public void AddEmployeeDetails()
        {
            using (var cmapp = new CM())
            {
                Console.Write("\nEnter Employee Name :- ");
                var name = Console.ReadLine();

                Console.WriteLine("\nWrite Designation :-");
                var designation = Console.ReadLine();

                Console.WriteLine("\n Email :-");
                var email = Console.ReadLine();

                Console.WriteLine("\nEnter Mobile number :-");
                var mobile = Console.ReadLine();


                Employee employee = new Employee(name, designation, email, mobile);
                 cmapp.Employees.Add(employee);
                    cmapp.SaveChanges();
                    Console.WriteLine("\nAdded Successfully\n");
                
            }
        }




        public void DeleteEmployeeDetails()
        {
            using (var cmapp = new CM())
            {

                var emp = new Employee();
                {

                    Console.WriteLine("Enter Employee Id");
                    emp.EmployeeId = Convert.ToInt32(Console.ReadLine());
                    var check = cmapp.Employees.Where(t => t.EmployeeId == emp.EmployeeId);
                    if (check != null)
                    {
                        cmapp.Employees.Remove(emp);
                        cmapp.SaveChanges();
                        Console.WriteLine("\nInformation is successfully Deleted!!\n");
                    }
                    else
                    {
                        Console.WriteLine("No Existing for this Id!!");
                    }

                }

            }
        }


        public void AddBusinessUnit()
        {
            using (var cmapp = new CM())
            {
                Console.Write("\nEnter Business unit  Name :- ");
                var name = Console.ReadLine();

                Console.WriteLine("\nWrite Description :-");
                var description = Console.ReadLine();

                Console.WriteLine("\n Unit location :-");
                var location = Console.ReadLine();


                BusinessUnit businessUnit = new BusinessUnit(name, description, location);
                
                    cmapp.BusinessUnits.Add(businessUnit);
                    cmapp.SaveChanges();
                    Console.WriteLine("\nAdded Successfully\n");
               
            }
        }


        public void DeleteBusinessUnit()
        {
            using (var cmapp = new CM())
            {

                var bunit = new BusinessUnit();
                {


                    Console.WriteLine("Enter Business Unit Id\n");
                    bunit.BusinessUnitId = Convert.ToInt32(Console.ReadLine());
                    var check = cmapp.BusinessUnits.Where(t => t.BusinessUnitId == bunit.BusinessUnitId);
                    if (check != null)
                    {
                        cmapp.BusinessUnits.Remove(bunit);
                        cmapp.SaveChanges();
                        Console.WriteLine("\nInformation is successfully Deleted!!\n");
                    }
                    else
                    {
                        Console.WriteLine("\nNo Existing for this Id!!");
                    }

                }

            }
        }





        public void AddProjectInfo()
        {
            using (var cmapp = new CM())
            {
                Console.Write("\nEnter Project  Name :- ");
                var name = Console.ReadLine();

                Console.WriteLine("\nWrite Project Description :-");
                var description = Console.ReadLine();

                Console.WriteLine("\n Enter Business unit id :-");
                var bunit = Convert.ToInt32(Console.ReadLine());


                Project project = new Project(name, description, bunit);
                cmapp.Projects.Add(project);
                    cmapp.SaveChanges();
                    Console.WriteLine("\nAdded Successfully\n");
               
            }

        }



        public void DeleteProjectInfo()
        {
            using (var cmapp = new CM())
            {

                var project = new Project();
                {


                    Console.WriteLine("\nEnter ProjectId");
                    project.ProjectId = Convert.ToInt32(Console.ReadLine());
                    var check = cmapp.Projects.Where(t => t.ProjectId == project.ProjectId);
                    if (check != null)
                    {
                        cmapp.Projects.Remove(project);
                        cmapp.SaveChanges();
                        Console.WriteLine("\nInformation is successfully Deleted!!\n");
                    }
                    else
                    {
                        Console.WriteLine("\nNo  Existing for this Id!!");
                    }

                }

            }
        }



        public void EmployeeList()
        {
            using (var cmapp = new CM())
            {

                var emp = cmapp.Employees.ToList();

                foreach (var item in emp)
                {
                    Console.WriteLine($" Employee Id: {item.EmployeeId}, Employee Name: {item.EmployeeName}, Designation: {item.Designation}, Email: {item.Email}, Mobile: {item.Mobile} \n");
                }

            }
        }



        public void EmployeeVacationList()
        {
            using (var cmapp = new CM())
            {

                var emp = cmapp.Vacations.ToList();

                foreach (var item in emp)
                {
                    Console.WriteLine($"  Vacation Id: {item.VacationId},  Employee Id: {item.EmployeeId},  Duration: {item.Duration} \n");
                }

            }
        }



        public void AssignVacation()
        {
            using (var cmapp = new CM())
            {
                Console.Write("\nEnter Duration of vacation:- ");
                var duration = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter Employee  id :-");
                var empId = Convert.ToInt32(Console.ReadLine());



                Vacation vacation = new Vacation(duration, empId);
               
                    cmapp.Vacations.Add(vacation);
                    cmapp.SaveChanges();
                    Console.WriteLine("\nAdded Successfully\n");
                
            }
        }

        public void AssignProjects()
        {

            using (var cmapp = new CM())
            {

                var vac = new Vacation();
                {

                    Console.WriteLine("Enter Employee Id");
                    vac.EmployeeId = Convert.ToInt32(Console.ReadLine());

                    var check = cmapp.Vacations.Where(t => t.EmployeeId == vac.EmployeeId);

                    if (check == null)
                    {
                        
                        

                        Console.WriteLine("\nWrite Employee Role :-");
                        var empRole = Console.ReadLine();

                        Console.WriteLine("\n Enter Eployee id :-");
                        var empId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\n Enter Project id :-");
                        var proId = Convert.ToInt32(Console.ReadLine());

                        AssignProject assignProject = new AssignProject(empRole, empId, proId);

                        {
                            cmapp.Assignprojects.Add(assignProject);
                            cmapp.SaveChanges();
                            Console.WriteLine("\nProject Assigned\n");

                        }


                    }
                    else
                    {
                        Console.WriteLine("\nEmployee is on cvacation and the project can not be assigned to the employee");
                    }

                }




            }


        }


        public void ViewAssignedProjects()
        {
            using (var cmapp = new CM())
            {

                var assPro = cmapp.Assignprojects.ToList();

                foreach (var item in assPro)
                {
                    Console.WriteLine($"  Assign Project Id: {item.AssignProjectId}, Employee Role: {item.EmployeeRole}, EmployeeId: {item.EmployeeId}, Project Id: {item.ProjectId} \n");
                }

            }
        }

        public void BusinessUnitList()
        {
            using (var cmapp = new CM())
            {

                var bulist = cmapp.BusinessUnits.ToList();

                foreach (var item in bulist)
                {
                    Console.WriteLine($"  Business Unit Id: {item.BusinessUnitId}, Business Unit Name: {item.BusinessUnitName} \n");
                }

            }
        }



    }
}



