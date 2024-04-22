using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    public int solution(int a, int b)
    {
        // a ⊕ b와 2 * a * b를 계산
        int concatResult = Concatenate(a, b);
        int multiplyResult = 2 * a * b;

        // 두 값 중 더 큰 값을 반환
        return Math.Max(concatResult, multiplyResult);
    }

    // 두 정수를 붙여서 새로운 정수로 만드는 함수
    private int Concatenate(int a, int b)
    {
        int temp = b;
        while (temp > 0)
        {
            a *= 10;
            temp /= 10;
        }
        return a + b;
    }
}