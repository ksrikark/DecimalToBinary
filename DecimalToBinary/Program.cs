using System;
using System.Collections.Generic;

int n = 5;
var digits = new List<int>();
while (n > 0)
{
    digits.Add(n % 2);
    n = n / 2;
}
for (int i = digits.Count - 1; i >= 0; i--)
{
    Console.Write(digits[i]);
}

