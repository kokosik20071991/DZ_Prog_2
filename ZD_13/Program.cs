int a = int.Parse(Console.ReadLine());
if(a.ToString().Length<3){
    Console.WriteLine($"Третьей цифры в числе {a} нет."); 
}
else
{
    int b = a;
    int ost;
    for(int i=0;i<a.ToString().Length;i++)
    {
            ost = b%10; 
            b = b/10;
        if(a.ToString().Length - i == 3)
        {
            Console.WriteLine($"Третья цифра в числе {a} - {ost}");
        }
    }
    
}
 