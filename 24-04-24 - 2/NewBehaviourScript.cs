using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    public int solution(int a, int b, bool flag)
    {
        // flag 값에 따라 다른 연산을 수행하여 결과를 반환
        if (flag)
        {
            return a + b; // flag가 true인 경우 a와 b를 더함
        }
        else
        {
            return a - b; // flag가 false인 경우 a와 b를 뺌
        }
    }
}