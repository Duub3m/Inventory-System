public class Department : Employee{

bool inventoryPromptCheck = false;

  public void DepartmentInput(){
      if(managerCheck == true){
        Console.WriteLine("What Would You Like To Do. \nAdd Employee(A) \nCheck Inventory(I) \nExit System(E)");
        inventoryPrompts = Console.ReadLine();

      switch(inventoryPrompts.ToUpper()){
        case "A":
        AddEmployees();
        break;
        case "I":
        DepartmentCheck();
        break;
        case "E":
        Console.WriteLine("System Exit Successful");
        break;
        default:
        Console.WriteLine("Not A Valid Input");
        break;
      }
      }

      else if(employeeCheck == true){
         Console.WriteLine("What Would You Like To Do. \nCheck Inventory(I) \nExit System(E)");
          inventoryPrompts = Console.ReadLine();

        while (!inventoryPromptCheck){
          switch(inventoryPrompts.ToUpper()){
            case "I":
            DepartmentCheck();
            break;
            case "E":
            Console.WriteLine("System Exit Successful");
            inventoryPromptCheck=true;
            break;
            default:
            Console.WriteLine("Not A Valid Input");
            inventoryPromptCheck=true;
            break;
          }
      }
      }
      else{
        //Checks to bool value of Manager and Employee
        Console.WriteLine("You Do Not Have Authorization To Access This System.");
      }
  }


      
}
