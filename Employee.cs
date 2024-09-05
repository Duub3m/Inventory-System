public class Employee : Inventory{

  //Checks if the ID is a Manager
  protected bool managerCheck=false;

  //Checks if the ID is an Employee
  protected bool employeeCheck = false;

  //Input string for employee ID
  protected string employeeIdInput;

  
  protected int newEmployeeId;

  protected bool newEmployeeIdCheck = false;

  protected string newEmployeeIdString;

  public void Employees(){
  employeeIdList.Add("2");
  
  }


  public void AddEmployees(){
    Random random = new Random();
    Console.WriteLine("Employee First Name: ");
    string employeeFirstName = Console.ReadLine();
    Console.WriteLine("Employee Last Name: ");
    string employeeLastName = Console.ReadLine();
  
    while(!newEmployeeIdCheck){
        newEmployeeId = random.Next(10000000,99999999);
        newEmployeeIdString = Convert.ToString(newEmployeeId);
        if (!employeeIdList.Contains(newEmployeeIdString)){
          employeeIdList.Add(newEmployeeIdString);
          Console.WriteLine("Hello " + employeeFirstName + " " + employeeLastName + "!" + " Your ID Number Is: " + newEmployeeIdString); 
          newEmployeeIdCheck = true;
        }
        else{
          Console.WriteLine("Duplicate ID. Searching for Unique one...");
        }
    }
  }
  public void Authentication(){
    while (!employeeCheck && !managerCheck)
    {
    Console.WriteLine("Enter Your EmployeeID");
    employeeIdInput = Console.ReadLine();
    if (employeeIdList.Contains(employeeIdInput)){
      employeeCheck=true;
      Console.WriteLine("Authentication Successful");
    }
    else if(managerIdList.Contains(employeeIdInput)){
      managerCheck=true;
      Console.WriteLine("Authentication Successful");
    }
    else{
      Console.WriteLine("Authentication Failed. Please Try Again.");
    }
  }
}

}