using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine(); //한 줄의 입력을 받아서 문자열 변수 s에 저장

        String result = ""; //결과를 저장할 빈 문자열 초기화 변수result는 문자열을 저장하기 위한 용도

        foreach (char c in s) //문자열 s의 각 문자에 대해 반복합니다.
        {
            if (char.IsLower(c)) //현재 문자가 소문자인지 확인
            {
                result += char.ToUpper(c); // += 뜻 result = result + char.ToUpper(c)  //소문자를 대문자로 변경하여 결과에 추가
            }
            else if (char.IsUpper(c)) //현재 문자가 대문자인지 확인
            {
                result += char.ToLower(c); //대문자를 소문자로 변경하여 결과에 추가
            }
        }

        Console.WriteLine(result); //결과 문자열을 출력

    }
}