Console.WriteLine("enter the customer id");
string customerId = Console.ReadLine() ;
Console.WriteLine("enter the customer name");
string customerName=Console.ReadLine();
Console.WriteLine("enter the customer membership");
string memberShip = Console.ReadLine();
memberShip = memberShip.ToUpper();

float payBill;
if(memberShip=="GOLDEN")
{
    Console.WriteLine("you have a discount despite of you are having golden membership");
    Console.WriteLine("enter the Order amount");
    int orderAmount = Convert.ToInt32(Console.ReadLine());
    if(orderAmount >50)
    {
        Console.WriteLine("the total Discount for you is 20%");
        
        payBill =orderAmount - orderAmount* 20 / 100 ;
        Console.WriteLine("the amount you have to pay is " + payBill);
    }
    else
    {
        Console.WriteLine("as of now you have no discount offer ");
        Console.WriteLine("the payment is " + orderAmount);
    }
}
else if(memberShip=="SILVER")
{
    Console.WriteLine("you have a discount despite of you are having silver membership");
    Console.WriteLine("enter the Order amount");
    int orderAmount = Convert.ToInt32(Console.ReadLine());
    if (orderAmount > 30)
    {
        Console.WriteLine("the total Discount for you is 10%");
        
        payBill = orderAmount - orderAmount*(10 / 100) ;
        Console.WriteLine("the amount you have to pay is " + payBill);
    }
    else
    {
        Console.WriteLine("as of now you have no discount offer ");
        Console.WriteLine("the payment is " + orderAmount);
    }
}
else if(memberShip=="BRONZE")
{
    Console.WriteLine("you have a discount despite of you are having bronze membership");
    Console.WriteLine("enter the Order amount");
    int orderAmount = Convert.ToInt32(Console.ReadLine());
    if (orderAmount > 0)
    {
        Console.WriteLine("the total Discount for you is 5%");
        
        payBill = orderAmount - orderAmount*(5 / 100) ;
        Console.WriteLine("the amount you have to pay is " + payBill);
    }
    else
    {
        Console.WriteLine("as of now you have no discount offer ");
        Console.WriteLine("the payment is " + orderAmount);
    }
}
else if(memberShip==null)
{
    Console.WriteLine("you don't have any discount despite of you are not having any membership");
    Console.WriteLine("enter the Order amount");
    int orderAmount = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("as of now you have no discount offer ");
    Console.WriteLine("the payment is " + orderAmount);

}