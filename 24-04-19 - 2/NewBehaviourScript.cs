using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    public string solution(string str1, string str2)
    {
        string result = ""; // 결과를 저장할 문자열 변수

        // 두 문자열의 길이가 같으므로 한 문자열의 길이를 기준으로 반복합니다.
        for (int i = 0; i < str1.Length; i++)
        {
            // 번갈아가며 문자열을 추가합니다.
            result += str1[i];
            result += str2[i];
        }

        return result;
    }
}
