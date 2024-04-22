using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    // 문자열 s를 n번 반복하여 반환하는 함수
    public string solution(string s, int n)
    {
        string answer = "";
        // n번 반복하는 반복문
        for (int i = 0; i < n; i++)
        {
            // 문자열 s를 answer에 추가
            answer += s;
        }
        // 결과 문자열 반환
        return answer;
    }
}
