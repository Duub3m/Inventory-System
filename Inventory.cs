using System.Collections.Generic;
public class Inventory{
  protected bool departmentCheck=false;

  protected bool clothingTypeCheck=false;

  protected bool clothingColorCheck=false;

  protected string departmentInput;

  protected string departmentId;

  protected string typeInput;

  protected string typeId;

  protected string colorInput;

  protected string num = "3";

  protected string inventoryPrompts;


  protected List<String> employeeIdList = new List<String>{"0", "1"};

  protected List<String> managerIdList = new List<String>{"10", "11"};


    public void DepartmentCheck(){
      while (!departmentCheck){
        Console.WriteLine("Choose A Department: Mens(M) Womens(W) Kids(K) Baby(B) ");
        departmentInput = Console.ReadLine();

      switch(departmentInput.ToUpper()){
        case "M":
        departmentId = "01";
        departmentCheck = true;
        Console.WriteLine("You Chose The Mens Department");
        ClothingTypeCheck();
        break;
        case "W":
        departmentId = "02";
        departmentCheck = true;
        Console.WriteLine("You Chose The Womens Department");
        ClothingTypeCheck();
        break;
        case "K":
        departmentId= "03";
        departmentCheck = true;
        Console.WriteLine("You Chose The Kids Department");
        ClothingTypeCheck();
        break;
        case "B":
        departmentId="04";
        departmentCheck = true;
        Console.WriteLine("You Chose The Baby Department");
        ClothingTypeCheck();
        break;
        default:
        Console.WriteLine("This Is Not a Valid Department ID. Please Try Again");
        break;
      }
    }
  }

  public void ClothingTypeCheck(){
    while (!clothingTypeCheck){
    Console.WriteLine("What Type of Clothes are you Looking For: \nOuterwear(O) \nTops(T) \nBottoms(B) \nShoes(S)");
    typeInput = Console.ReadLine();
    switch (typeInput.ToUpper()){
      case "O":
      Console.WriteLine("You Chose Outerwear");
      typeId= "100";
      clothingTypeCheck = true;
      ClothingColorCheck();
      break;
      case "T":
      Console.WriteLine("You Chose Tops");
      typeId= "200";
      clothingTypeCheck = true;
      ClothingColorCheck();
      break;
      case "B":
      Console.WriteLine("You Chose Bottoms");
      typeId= "300";
      clothingTypeCheck = true;
      ClothingColorCheck();
      break;
      case "S":
      Console.WriteLine("You Chose Shoes");
      typeId= "400";
      clothingTypeCheck = true;
      ClothingColorCheck();
      break;
      default:
      Console.WriteLine("This is not a valid input");
      break;
    }
  }
  }

  public void ClothingColorCheck(){
    while (!clothingColorCheck){
    Console.WriteLine("What Color are you Looking For: \nRed(R) \nGreen(G) \nBlue(B)");
    colorInput = Console.ReadLine();
    switch (colorInput.ToUpper()){
      case "R":
      Console.WriteLine("You Chose Red");
      clothingColorCheck = true;
      break;
      case "G":
      Console.WriteLine("You Chose Green");
      clothingColorCheck = true;
      break;
      case "B":
      Console.WriteLine("You Chose Blue");
      clothingColorCheck = true;
      break;
      default:
      Console.WriteLine("This is not a valid Input");
      break;
    }
  }
  }


  /*
  Department:

  Mens (01)

  Womens (02)

  Kids (03)

  Baby (04)

  */

  /*
  ClothingType:

  Outerwear (100)

  Top (200)

  Bottoms (300)

  Shoes (400)

  Colors:

  red (11)
  blue (12)
  green (13)
  yellow (14)
  purple (15)
  orange (16)
  pink (17)
  brown (18)
  white (19)
  grey (20)
  black (21)

  */

  

  
}