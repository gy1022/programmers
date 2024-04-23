using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution
{
    public int solution(int number, int n, int m)
    {
        // number가 n의 배수이면서 m의 배수인지 확인하여 결과 반환
        if (number % n == 0 && number % m == 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
