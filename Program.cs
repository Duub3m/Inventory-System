// See https://aka.ms/new-console-template for more information

public class Program{

  public static void Main(string[] args){
    while(true){
   RunInventory();
    }
  }
  public static void RunInventory(){
    Console.WriteLine("\nHello! Welcome To Our Retail Inventory.");
  
    Department department = new Department();
    department.AddEmployees();
    department.Employees();
    department.Authentication();
    department.DepartmentInput();
    RunInventory();
  }
  public static void RunAuthentication(){
    Employee employee = new Employee();
    employee.Authentication();
  }

  
}
