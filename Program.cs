//вариант 1 высокий уравень
Console.WriteLine( "|     x  |     y  |");
for (double x = 0; x<=5; x+=0.25)
{ 
    double u = 0;
    double y = 0;
    if (x <= 2)
    {
        for (int k = 1; k < 5; k++)
        {
            u = k * x * x + k - x;

        }
    }
    else u = Math.Atan(x);
   

   
    y += 1.5 * Math.Abs(Math.Sin(u));
    Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");
}

