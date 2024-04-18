using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();        //초기화
        input = Console.ReadLine().Split(' ');      //' '안에 있는거 지우기

        String s1 = input[0];       //s1이 0번
        String s2 = input[1];       //s2가 1번
        String output = s1 + s2.Replace(" ", "");      //공백을 제거한 s2를 생성하고 s1과 결합하여 output에 저장
                                                       //String.Replace(" ", "") --> 문자열에서 특정 문자열을 다른 문자열로 대체. 현재는 " "를 ""로 대체함 공백을 없앤거

        Console.WriteLine(output);
    }
}