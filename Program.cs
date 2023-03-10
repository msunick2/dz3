//1

// Console.WriteLine("number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >= 10000 && num <= 99999)
// {
//     Console.WriteLine(polindrom(num));
// }
// else
// {
//     Console.WriteLine("error");
// }

// string polindrom(int n) 
// {
//     int n1 = n / 10000;
//     int n5 = n % 10;
//     int n2 = n / 1000 % 10;
//     int n4 = n % 100 / 10;
//     if(n1 == n5 && n2 == n4)
//     {
//         return "da";
//     }
//     else
//     {
//         return "net";
//     }
// }


//3

// Console.WriteLine("number");
// int n = Convert.ToInt32(Console.ReadLine());


// void cub(int num)
// {
// int a = 1;
// int b = 1;
// {
//     while(a <= n)
//     {
//         b = a * a * a;
//         Console.Write(" " + b);
//         a++;
//     }

// }
// }
// cub(n);


// 2

Console.WriteLine("input x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input z2");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input x3");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y3");
int y3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input z3");
int z3 = Convert.ToInt32(Console.ReadLine());

void s(int x1, int y1, int z1, int x2, int y2, int z2, int x3, int y3, int z3)
{
    
    double a = Convert.ToInt32(Math.Sqrt(Math.Pow((x2 - x1) , 2) + Math.Pow((y2 - y1) , 2) + Math.Pow((z2-z1) , 2)));
    
    Console.Write("{0:0.00}", a);
}



s(x1, y1, z1, x2, y2, z2, x3, y3, z3);