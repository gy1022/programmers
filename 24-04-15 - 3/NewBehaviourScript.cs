using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');      //공백 지워서 4, 5로 나누기 

        int a = Int32.Parse(s[0]);      //0번에 a넣기
        int b = Int32.Parse(s[1]);      //1번에 b넣기

        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);      //0에 a 1에 b 2가 a+b
    }
}