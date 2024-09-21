Console.WriteLine("select the language");
Console.WriteLine("for kannada select choice 1");
Console.WriteLine("for hindi select choice 2");
Console.WriteLine("for english select choice 3");
Console.WriteLine("enter the choice");
int choice=Convert.ToInt32(Console.ReadLine());
switch(choice)
{
    case 1:
        Console.WriteLine("you are choosing kannada ");
        Console.WriteLine("your customer care executive is ms.sushma you can ask any doubt regarding to airtel sim");
        break ;
    case 2:
        Console.WriteLine("you are choosing hindi");
        Console.WriteLine("your customer care executive is ms.vishwa you can ask any doubt regarding to airtel sim");
        break;
    case 3:
        Console.WriteLine("you are choosing english");
        Console.WriteLine("your customer care executive is ms.viji you can ask any doubt regarding to airtel sim");
        break;

}