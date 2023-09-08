using System;
using System.Linq;


int[] scores = { 97, 92, 81, 60 };

var L =  from LQ in scores where LQ > 80 select LQ;

foreach (var l in L)
{
    Console.Write(l.ToString() + " ");
}

