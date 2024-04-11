using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();  //초기화
        input = Console.ReadLine().Split(' ');  //문자열을 배열해서 넣어줌 현재는 스페이스 기준

        String result = "";  //문자열 초기화 ""

        for (int i = 0; i < Int32.Parse(input[1]); i++) //i를 0번으로 놓고 input[1] = 5, i++ 이니까 5번 반복
        {
            result += input[0]; //입력된 문자열 input[0]을 input[1]번 반복하여 결과 문자열에 추가합니다.
        }

