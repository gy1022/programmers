using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class Solution
{
    public string solution(string[] arr)
    {
        StringBuilder sb = new StringBuilder(); // 문자열을 효율적으로 처리하기 위한 StringBuilder 생성

        // 배열 arr의 각 원소를 순회하면서 StringBuilder에 추가합니다.
        foreach (string str in arr)
        {
            sb.Append(str);
        }

        // StringBuilder에 저장된 문자열을 반환합니다.
        return sb.ToString();
    }
}