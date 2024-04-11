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
        s = Console.ReadLine().Split(' '); //자르는 함수 스페이스를 자름

        int a = Int32.Parse(s[0]); //4 Parse(s[0]) - 1번. 컴퓨터는 0부터 시작이니까 0 넣은거 
        int b = Int32.Parse(s[1]); //5 Parse(s[1]) -2번인거지

        Console.WriteLine("a = {0}", a); // {0} = a 0은 칸
        Console.WriteLine("b = {0}", b);// {0} = b 0은 칸
    }
}
