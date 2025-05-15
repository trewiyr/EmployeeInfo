
using ConsoleAdoDotNet;

// string connectionString = "Data Source=DESKTOP-94O70OH;Initial Catalog=EmployeeDb;Integrated Security=True;Trust Server Certificate=True";

string mySqlConnectionString = "server=localhost; user=root; database=EmployeeDb; password =  ";
var employeeService = new EmployeeService(mySqlConnectionString);

while (true)
{
    Console.WriteLine("\nEmployee Management System");
    Console.WriteLine("1. Add Employee");
    Console.WriteLine("2. View All Employees");
    Console.WriteLine("3. View Employee by ID");
    Console.WriteLine("4. Update Employee");
    Console.WriteLine("5. Delete Employee");
    Console.WriteLine("6. Exit");
    Console.Write("Enter your choice: ");

    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        continue;
    }

    switch (choice)
    {
        case 1:
            await employeeService.AddEmployee();
            break;
        case 2:
            await employeeService.ViewAllEmployees();
            break;
        case 3:
            await employeeService.ViewEmployeeById();
            break;
        case 4:
            await employeeService.UpdateEmployee();
            break;
        case 5:
           await employeeService.DeleteEmployee();
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}