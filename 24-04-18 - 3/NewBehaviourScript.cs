using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example
{
    public static void Main()
    {
        // 사용자로부터 자연수 n을 입력받음
        int n = int.Parse(Console.ReadLine());

        // n이 짝수인지 홀수인지 판별하여 결과 출력
        if (n % 2 == 0)
        {
            Console.WriteLine(n + " is even"); // n이 짝수일 때 출력
        }
        else
        {
            Console.WriteLine(n + " is odd"); // n이 홀수일 때 출력
        }
    }
}