string studentId;
string studentName;
int tamilMark;
int englishMark;
int mathsMark;
int scienceMark;
int socialMark;
Console.WriteLine("enter the studentId");
studentId = Console.ReadLine();
Console.WriteLine("enter the studentName");
studentName = Console.ReadLine();
Console.WriteLine("enter the mark of tamil");
tamilMark=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the mark of english");
englishMark = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the mark of maths");
mathsMark = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the mark of science");
scienceMark = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the mark of social");
socialMark = Convert.ToInt32(Console.ReadLine());
int total=tamilMark+englishMark+mathsMark+scienceMark+socialMark;
Console.WriteLine("total of the student mark is " + total);
int average = total / 5;
Console.WriteLine("average of the student mark is "+average);
if (average >= 35 )
{
    if (average >= 90 || average <= 100)
    {
        Console.WriteLine("excellent");
    }
    else if(average >=80 ||  average <=89)
    {
        Console.WriteLine("very good");
    }
    else if(average >=70 || average <= 79)
    {
        Console.WriteLine("good");
    }
    else if (average >=60 || average <=69)
    {
        Console.WriteLine("fair");
    }
    else if(average>=50 ||  average <=59)
    {
        Console.WriteLine("need to improvement");
    }
    else if(average >=40 || average <=49)
    {
        Console.WriteLine("below average");
    }
    else
    {
        Console.WriteLine("fail");
    }

}

