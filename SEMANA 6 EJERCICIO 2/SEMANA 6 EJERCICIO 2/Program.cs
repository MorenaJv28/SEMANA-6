using System;
using System.Linq;


int[] Score = { 90, 71, 82, 93, 75, 82 };

var LQ = from L in Score where L > 80 
         orderby L descending 
         select L;

foreach (var L in LQ)
{
    Console.WriteLine(L.ToString);

}

Console.WriteLine("Ing.Gutierrez");

