using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

class Solution
{
    public int solution(int n)
    {
        // 결과를 저장할 변수 초기화
        int answer = 0;

        // 1부터 n까지 반복하면서
        for (int i = 1; i <= n; i++)
        {
            // n이 홀수이고 현재 숫자 i도 홀수인 경우
            if (n % 2 == 1 && i % 2 == 1)
            {
                answer += i; // 현재 숫자 i를 더함
            }
            // n이 짝수이고 현재 숫자 i도 짝수인 경우
            else if (n % 2 == 0 && i % 2 == 0)
            {
                answer += i * i; // 현재 숫자 i의 제곱을 더함
            }
        }

        // 최종 결과 반환
        return answer;
    }
}
