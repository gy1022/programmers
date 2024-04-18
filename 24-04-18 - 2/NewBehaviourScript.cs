using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();        //초기화
        s = Console.ReadLine();     //한 줄의 입력을 받아서 문자열 변수 s에 저장

        foreach (char c in s)       // 문자열 s의 각 문자를 순회하면서 콘솔에 한 문자씩 출력
            Console.WriteLine(c);       //c출력

    }
}
