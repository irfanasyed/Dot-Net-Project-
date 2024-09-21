int choice;
int unit;
Console.WriteLine("enter the coice");
choice = Convert.ToInt32(Console.ReadLine());
switch(choice)
{
    case 1:
        Console.WriteLine("Residential EB charge");
        Console.WriteLine("======================");
        Console.WriteLine("enter the consumed unit");
        unit = Convert.ToInt32(Console.ReadLine());
        if (unit >= 1 && unit <= 50)
        {
           Console.WriteLine("Your EB bill is 0Rs");
        }
        else if (unit >= 51 && unit <= 150)
        {
           float ebCost = 5.50f;
           
           ebCost =( unit-50) * ebCost; 
           Console.WriteLine("Your EB bill is " + ebCost);
        }
        else if (unit >= 151 && unit <= 250)
        {
           float ebCost = 8.50f;
           
           ebCost = (unit-50) * ebCost; ;
           Console.WriteLine("Your EB bill is " + ebCost);
        }
        else if (unit >= 251 && unit <= 500)
        {
            float ebCost = 13;
            
            ebCost = (unit - 50) * ebCost; ;
            Console.WriteLine("Your EB bill is " + ebCost);
        }
        
        break;
    case 2:
        Console.WriteLine("Commercial EB Charge");
        Console.WriteLine("====================");
        Console.WriteLine("enter the consumed unit");
        unit = Convert.ToInt32(Console.ReadLine());
        if (unit >= 1 && unit <= 50)
        {
            Console.WriteLine("Your EB bill is 10Rs");
        }
        else if (unit >= 51 && unit <= 150)
        {
            float ebCost = 15.50f;
            
            ebCost = (unit-50) * ebCost; ;
            Console.WriteLine("Your EB bill is " + ebCost);
        }
        else if (unit >= 151 && unit <= 250)
        {
            float ebCost = 18.50f;
            
            ebCost = (unit-50) * ebCost; ;
            Console.WriteLine("Your EB bill is " + ebCost);
        }
        else if (unit >= 251 && unit <= 500)
        {
            float ebCost = 13;
            
            ebCost = (unit-50) * ebCost; ;
            Console.WriteLine("Your EB bill is " + ebCost);
        }
        break;
    default:
        Console.WriteLine("enter a valid choice");
        break;
}

    